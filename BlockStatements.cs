// VisitCSharp.cs

using System;
using System.Collections.Generic;
using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CsDisplay
{
  internal partial class VisitCSharp : CSharpSyntaxWalker
  {

    // BLOCK STATEMENTS AND CONSTRUCTS

    public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {

      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "PropertyDeclaration");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, "name:" + node?.Identifier.Text.ToString());

      var cnt = node?.AccessorList?.Accessors.Count.ToString();
      int count;
      if (cnt == null)
        count = 0;
      else
        count = int.Parse(cnt);

      OurLine.AddEssentialInfo(ref nl, "count:" + node?.AccessorList?.Accessors.Count.ToString());

      if (count > 0)
        OurLine.AddExtraInfo(ref nl, "accessor1:" + node?.AccessorList?.Accessors[0].Keyword.Text);
      if (count > 1)
        OurLine.AddExtraInfo(ref nl, "accessor2:" + node?.AccessorList?.Accessors[1].Keyword.Text);
      // sometimes has body etc..
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("PropertyDeclaration");
      base.VisitPropertyDeclaration(node);
      EndBlock("PropertyDeclaration");
    }

    public override void VisitForStatement(ForStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ForStatement");
      if (node.Condition != null) OurLine.AddEssentialInfo(ref nl, "condition:" + node.Condition.ToString());
      if (node.Declaration != null) OurLine.AddEssentialInfo(ref nl, "declaration:" + node.Declaration.ToString());
      if (node.Statement != null) OurLine.AddEssentialInfo(ref nl, "statement:" + node.Statement.ToString());
      if (node.Incrementors != null) OurLine.AddEssentialInfo(ref nl, "incrementors:" + node.Incrementors.ToString());
      if (node.Initializers != null) OurLine.AddEssentialInfo(ref nl, "initializers:" + node.Initializers.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("ForStatement");
      base.VisitForStatement(node);
      EndBlock("ForStatement");

    }
    public override void VisitIfStatement(IfStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "IfStatement");
      // condition, statement, else.statement
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, "condition:" + node.Condition.ToString());
      OurLine.AddEssentialInfo(ref nl, "statement:" + node.Statement.ToString());
      var elsey = node.Else?.Statement;
      if (elsey != null)
        OurLine.AddEssentialInfo(ref nl, "else:" + elsey.ToString());


      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      StartBlock("IfStatement");
      base.VisitIfStatement(node);
      EndBlock("IfStatement");
    }
    public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "EnumDeclaration");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, "name:" + node.Identifier.Text.ToString());
      // System.Console.WriteLine(nl);
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("EnumDeclaration");
      base.VisitEnumDeclaration(node);
      EndBlock("EnumDeclaration");
    }
    public override void VisitClassDeclaration(ClassDeclarationSyntax node)
    {
      var clsname = node.Identifier.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "ClassDeclaration");
      OurLine.AddEssentialInfo(ref nl, "name:" + clsname);
      if (node.BaseList != null)
      {
        var baseTypes = node.BaseList.Types.ToString(); //.Select((t) => t.Type.Identifier.Text.ToString()).Join(", ");
        if (debug) System.Console.WriteLine(baseTypes);
        OurLine.AddEssentialInfo(ref nl, "basetypes:" + baseTypes);
      }
      // nl.Source = node.ToFullString();
      // currentClass = node;
      var modifiers = node.Modifiers;
      OurLine.AddExtraInfo(ref nl, "modifiers:" + modifiers.ToString());

      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("ClassDeclaration");
      base.VisitClassDeclaration(node);
      EndBlock("ClassDeclaration");
    }

    public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
      var name = node.Identifier.ToString();
      var arity = node.ParameterList.Parameters.Count;
      var nl = OurLine.NewLine(LineKind.Decl, "MethodDeclaration");
      var mod = node.Modifiers.ToString();
      var ret = node.ReturnType.ToString();
      OurLine.AddEssentialInfo(ref nl, "name:" + name);
      OurLine.AddEssentialInfo(ref nl, "return:" + ret);
      OurLine.AddExtraInfo(ref nl, "modifiers:" + mod);
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      // currentMethod = node;
      StartBlock("MethodDeclaration");
      base.VisitMethodDeclaration(node);
      EndBlock("MethodDeclaration");
    }
    public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
    {

      var name = node.Name.ToString();
      // currentNamespace = null;
      var nl = OurLine.NewLine(LineKind.Decl, "NamespaceDeclaration");
      OurLine.AddEssentialInfo(ref nl, "name:" + name);
      // nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      // currentNamespace = node;
      StartBlock("NamespaceDeclaration"); // worked wonderfully!
      base.VisitNamespaceDeclaration(node);
      EndBlock("NamespaceDeclaration"); // god is good!

    }

    public override void VisitLockStatement(LockStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "LockStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("LockStatement");

      StartBlock("LockStatement");
      base.VisitLockStatement(node);
      EndBlock("LockStatement");
    }



    public override void VisitUsingStatement(UsingStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("UsingStatement"); var nl = OurLine.NewLine(LineKind.Decl, "UsingStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      StartBlock("UsingStatement");
      base.VisitUsingStatement(node);
      EndBlock("UsingStatement");

    }

    public override void VisitTryStatement(TryStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("TryStatement"); var nl = OurLine.NewLine(LineKind.Decl, "TryStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      StartBlock("TryStatement");
      base.VisitTryStatement(node);
      EndBlock("TryStatement");

    }
    public override void VisitUnsafeStatement(UnsafeStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("UnsafeStatement"); var nl = OurLine.NewLine(LineKind.Decl, "UnsafeStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("UnsafeStatement");
      base.VisitUnsafeStatement(node);
      EndBlock("UnsafeStatement");
    }
    public override void VisitWhileStatement(WhileStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("WhileStatement"); var nl = OurLine.NewLine(LineKind.Decl, "WhileStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("WhileStatement");
      base.VisitWhileStatement(node);
      EndBlock("WhileStatement");
    }
    public override void VisitCheckedStatement(CheckedStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("CheckedStatement"); var nl = OurLine.NewLine(LineKind.Decl, "CheckedStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("CheckedStatement");
      base.VisitCheckedStatement(node);
      EndBlock("CheckedStatement");
    }
    public override void VisitDoStatement(DoStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("DoStatement"); var nl = OurLine.NewLine(LineKind.Decl, "DoStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("DoStatement");
      base.VisitDoStatement(node);
      EndBlock("DoStatement");

    }
    public override void VisitElseClause(ElseClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ElseClause"); var nl = OurLine.NewLine(LineKind.Decl, "ElseClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("ElseClause");
      base.VisitElseClause(node);
      EndBlock("ElseClause");
    }
    public override void VisitFinallyClause(FinallyClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("FinallyClause"); var nl = OurLine.NewLine(LineKind.Decl, "FinallyClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("FinallyClause");
      base.VisitFinallyClause(node);
      EndBlock("FinallyClause");

    }


    public override void VisitFixedStatement(FixedStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("FixedStatement"); var nl = OurLine.NewLine(LineKind.Decl, "FixedStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("FixedStatement");
      base.VisitFixedStatement(node);
      EndBlock("FixedStatement");
    }
    public override void VisitForEachStatement(ForEachStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ForEachStatement"); var nl = OurLine.NewLine(LineKind.Decl, "ForEachStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("ForEachStatement");
      base.VisitForEachStatement(node);
      EndBlock("ForEachStatement");

    }
    public override void VisitSwitchStatement(SwitchStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("SwitchStatement"); var nl = OurLine.NewLine(LineKind.Decl, "SwitchStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("SwitchStatement");

      StartBlock("SwitchStatement");
      base.VisitSwitchStatement(node);
      EndBlock("SwitchStatement");
    }
  }
}