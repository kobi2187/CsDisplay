using System;
using System.Collections.Generic;
using System.IO;
// using System.collections.Generic;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;
// using System.Threading.Tasks;


namespace CsDisplay
{
  static class Program  // use shell to collect the displayed results: $ CsDisplay x.cs > x.csast
  {
    public static bool dir;
    static string saveDirName;
    public static Dictionary<string, int> counter = new Dictionary<string, int>();
    static DateTime AppBuildTime;
    static void handleFile(string f)
    {
      System.Console.WriteLine("file is: " + f);
      GC.Collect();
      FileInfo finfo = new FileInfo(f);
      var f2 = finfo.FullName.Replace(".cs", ".csast");
      var astFile = new FileInfo(f2);
      // if csast newer than app's mtime, return
      if ((!Prefs.debug) && Prefs.skipOlder && (astFile.LastWriteTime > AppBuildTime)) { System.Console.WriteLine(); return; }
      if (Program.saveDirName != null)
        Console.Write(f.Replace(saveDirName, "").Split("/")[0] + "\t");

      Console.WriteLine(finfo.Name);

      if (Prefs.displayOnly)
      {
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine("----- BEGIN FILE:" + f + " -----");
      }


      // var reAnnotation = new Regex(@"^\s*\n*\[(\w+:)?\s*\n*([\w.]+(\(.*?\))?\s*,?\s*)+\s*\n*\]\s*$", RegexOptions.Multiline | RegexOptions.Compiled); // Remove annotations.
      // var reAnnotation = new Regex(@"^\s*\n*\[(\w+:)?\s*\n*([\w.]+(\(.*?\))?\s*,?\s*)+\s*\n*\]\s*$", RegexOptions.Multiline | RegexOptions.Compiled); // Remove annotations.
      // var reAnnotation = new Regex(@"^\s*\[[A-Z].*?\]\s*$", RegexOptions.Multiline); // Remove annotations.
      var reAnnotation = new Regex(@"^\s*\[[A-Za-z].*?\]\s*$", RegexOptions.Multiline); // Remove annotations.
      var reAnnotationMulti = new Regex(@"^\s*\[[A-Z].*?\]", RegexOptions.Singleline | RegexOptions.Multiline); // Remove annotations.
      var reInnerAnnotation = new Regex(@"(?<=(,|\(|\s+))\[[A-Z].*?\]", RegexOptions.Multiline);
      // var reInnerAnnotation = new Regex(@"(?<=(,|\(|\s+))\[[A-Z]\w+\s*(\([\w\d]+\))?\]", RegexOptions.Multiline);

      var reLinecomment = new Regex(@"(?m)//.*$", RegexOptions.Multiline);
      var reMultiLineComment = new Regex(@"(?s)/\*.*?\*/");
      var reAssemblyLine = new Regex(@"^\s*\[assembly\s*:.*?\]$", RegexOptions.Multiline);
      // var reModuleLine = new Regex(@"^\s*\[module\s*:.*?\]$", RegexOptions.Multiline);

      // var reAssemblyLine = new Regex(@"^\s*\[assembly:(.*\n?)+\]");


      var content = File.ReadAllText(f);
      System.Console.WriteLine(content.Length);
      var count = 0;

      if (content.Contains("[assembly:")) //&& Regex.IsMatch(content, @"^\s*\[assembly:", RegexOptions.Multiline))
      {
        System.Console.WriteLine("FOUND IT!");
        // [assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ConfigR.Tests.Smoke.Service.Logging")]

        // content = reAssemblyLine.Replace(content, "");
        int b = -1;
        int idx;// = -1;
        do
        {
          idx = content.IndexOf("[assembly:", 0);
          if (idx >= 0)
          {

            b = content.IndexOf("]\r", idx);
            if (b == -1)
              b = content.IndexOf("]\n", idx);
            if (b == -1)
              b = content.IndexOf("]", idx);

            if (b >= 0)
            {
              var str = content.Substring(idx, b - idx + 1);
              System.Console.WriteLine("ASSEMBLY annotation!:" + str);
              System.Console.WriteLine("removing assembly line annotation!");
              content = content.Replace(str, "");
            }
          }
          ++count;
        } while (idx >= 0 && b >= 0 && count < 1000);
      }
      count = 0;
      while (reAssemblyLine.IsMatch(content) && count < 1000)
      {
        content = reAssemblyLine.Replace(content, "");
        ++count;

      }

      count = 0;
      while (count < 1000 && content.Contains("[") && content.Contains("]") && new Regex(@"^\s*\[", RegexOptions.Multiline).IsMatch(content) && reAnnotation.IsMatch(content))
      {
        System.Console.WriteLine("removing Annotation!");
        content = reAnnotation.Replace(content, "");
        ++count;
        // System.Console.WriteLine(content);
      }
      count = 0;
      while (reAnnotationMulti.IsMatch(content) && count < 1000)
      {
        System.Console.WriteLine("trying to remove multi-line Annotation!");
        content = reAnnotationMulti.Replace(content, "");
        // System.Console.WriteLine(content);
        ++count;
      }
      // TODO: it also removed valid indexers. need to match on a capture group i think. for now, handle it manually.:
      // no, added a "look-behind" to the regex so it seems to work now.
      count = 0;
      while (reInnerAnnotation.IsMatch(content) && count < 1000)
      {
        ++count;
        System.Console.WriteLine("trying to remove inner annotation");
        content = reInnerAnnotation.Replace(content, "");
        System.Console.WriteLine(content);
      }
      System.Console.WriteLine(content.Length);
      count = 0;
      while (content.Contains("//") && count < 1000)
      {
        content = reLinecomment.Replace(content, "").Trim();
        ++count;
      }
      count = 0;
      while (content.Contains("/*") && content.Contains("*/") && count < 1000)
      {
        ++count;
        content = reMultiLineComment.Replace(content, "");
      }

      Debug.Assert(!content.Contains("//"));
      Debug.Assert(!content.Contains("/*"));
      Debug.Assert(!content.Contains("*/"));

      File.WriteAllText(Path.ChangeExtension(f, ".precs"), content);

      SyntaxTree tree = CSharpSyntaxTree.ParseText(content);
      var cs = new VisitCSharp(f);
      var root = (CompilationUnitSyntax)tree.GetRoot();
      // var a = root.DescendantNodes();

      cs.Visit(root);
      cs.Finish();

      if (Prefs.displayOnly)
      {
        Console.WriteLine(cs.sb.ToString());
        Console.WriteLine("----- END FILE:" + f + " -----");

      }
      else
      {
        var newfile = Path.ChangeExtension(f, "csast");
        if (File.Exists(newfile))
        {
          File.Delete(newfile);
        }
        File.WriteAllText(newfile, cs.sb.ToString());
      }
      if (!dir) ReportTodo(cs.counter);
    }

    public static void ReportTodo(Dictionary<string, int> counter)
    {
      if (counter.Count > 0)
      {
        System.Console.WriteLine("TODO for this file:");
        var l = counter.ToList();
        l.Sort((a, b) => a.Value.CompareTo(b.Value));

        foreach (var kvp in l)
        {
          System.Console.WriteLine(kvp.Key + " :: " + kvp.Value);
        }
      }
    }
    public static void Main(string[] args)
    {
      var app = "/home/kobi7/currentWork/CsDisplay/bin/Release/netcoreapp2.2/CsDisplay.dll";
      AppBuildTime = new FileInfo(app).CreationTime;
      // TODO: get the running app's filename, get its last mod time. only handle files that their csast counterparts are older.
      var list = new List<string>();
      if (args.Length < 1)
      {
        System.Console.WriteLine("Please specify a .cs file");
        // System.Console.WriteLine("or a directory");
        return;
      }
      var file = args[0];

      if (Directory.Exists(file))
      {
        var dir = file;
        saveDirName = dir;
        list = Directory.GetFiles(dir, "*.cs", SearchOption.AllDirectories).ToList();
        // TODO: there is probably a yielding iterator so we don't need to list all files before beginning.
        // list.Sort((string a, string b) => a.ToLower().CompareTo(b.ToLower()));
        Program.dir = true;
      }
      else if (File.Exists(file) && file.EndsWith(".cs"))
      { list.Add(file); }
      else
      {
        System.Console.WriteLine("cannot find the .cs file");
        return;
      }
      int x = 0;
      foreach (var f in list)
      {
        x++;
        Console.Write(x * 100.0 / list.Count + " %" + "\t");
        handleFile(f);
      }
      if (Program.dir)
      {
        // if we have multiple files, we want the todo counter only at the end.
        ReportTodo(Program.counter);
      }
    }
  }
}
