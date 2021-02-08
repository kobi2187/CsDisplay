﻿using System;
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
      var reAnnotation = new Regex(@"^\s*\[.*?\]\s*$", RegexOptions.Multiline); // Remove annotations.
      var reLinecomment = new Regex(@"(?m)//.*$", RegexOptions.Multiline);
      var reMultiLineComment = new Regex(@"(?s)/\*.*?\*/");
      var reAssemblyLine = new Regex(@"\[assembly:.*(\n+.*)+\]");

      var content = File.ReadAllText(f);
      System.Console.WriteLine(content.Length);
      if (content.Contains("[") && content.Contains("]") && new Regex(@"^\s*\[", RegexOptions.Multiline).IsMatch(content) && reAnnotation.IsMatch(content))
      {
        System.Console.WriteLine("removing Annotation!");
        content = reAnnotation.Replace(content, "");
      }

      if (reAssemblyLine.IsMatch(content))
      {
        System.Console.WriteLine("removing assembly line annotation!");
        content = reAssemblyLine.Replace(content, "");

        // System.Console.WriteLine(content);
      }

      System.Console.WriteLine(content.Length);
      if (content.Contains("//"))
        content = reLinecomment.Replace(content, "").Trim();
      if (content.Contains("/*") && content.Contains("*/"))
        content = reMultiLineComment.Replace(content, "");

      Debug.Assert(!content.Contains("//"));
      Debug.Assert(!content.Contains("/*"));
      Debug.Assert(!content.Contains("*/"));
      SyntaxTree tree = CSharpSyntaxTree.ParseText(content);
      var cs = new VisitCSharp(f);
      var root = (CompilationUnitSyntax)tree.GetRoot();
      var a = root.DescendantNodes();

      cs.Visit(root);
      cs.Finish();

      if (Prefs.displayOnly)
      {
        Console.WriteLine(cs.sb.ToString());
        Console.WriteLine("----- END FILE:" + f + " -----");

      }
      else
      {
        File.WriteAllText(Path.ChangeExtension(f, "csast"), cs.sb.ToString());
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
      else if (File.Exists(file))
      {
        list.Add(file);

      }
      else
      {
        System.Console.WriteLine("File doesn't exist");
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
