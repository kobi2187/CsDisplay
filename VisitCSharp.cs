using Newtonsoft.Json;
// using System.Json;
// VisitCSharp.cs

using System;
using System.IO;
using System.Collections.Generic;
// using System.Linq;
using System.Text;
// using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
// using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CsDisplay
{
public enum LineKind { Decl,EndBlock}

partial class VisitCSharp :  CSharpSyntaxWalker
    {
    readonly bool debug = true;
    static int blockCount = 0;

public void LogCommand(OurLine line) {
    // var s = JsonConvert.SerializeObject(line);
    if (debug) Console.WriteLine(line);
    lines.Add(line);
}
public void EndBlock() {
    var nl =new OurLine(LineKind.EndBlock);
    LogCommand(nl);
}

public StringBuilder sb;
public JsonTextWriter json;
public List<OurLine> lines;
public VisitCSharp(string filename, SyntaxWalkerDepth depth = SyntaxWalkerDepth.Token) : base(depth)
{
    this.lines = new List<OurLine>();
    this.sb = new StringBuilder();
    var sw = new StringWriter(sb);
    this.json = new JsonTextWriter(sw);
    this.json.WriteStartObject();
    this.json.WritePropertyName("File");
    this.json.WriteValue(filename);
}

public void Finish() {
    var lines2 = JsonConvert.SerializeObject(this.lines);
    System.Console.WriteLine("Finishing...");
    System.Console.WriteLine(lines2);
    this.json.WritePropertyName("Lines");
    // this.json.WriteStartArray();
    this.json.WriteRaw(lines2);
    // this.json.WriteEndArray();
    // this.json.WriteRaw(lines);
    this.json.WriteRaw("}");

    // this.json.WriteEndObject();
}
public override void DefaultVisit(SyntaxNode node)  {
    base.DefaultVisit(node);
}

}
}
