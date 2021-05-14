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


    public override void VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("LocalFunctionStatement"); var nl = OurLine.NewLine(LineKind.Decl, "LocalFunctionStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("LocalFunctionStatement");
      StartBlock("LocalFunctionStatement");
      base.VisitLocalFunctionStatement(node);
      EndBlock("LocalFunctionStatement");
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
      OurLine.AddEssentialInfo(ref nl, "modifiers:" + node.Modifiers.ToString());
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


    public override void VisitSwitchSection(SwitchSectionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "SwitchSection");
      OurLine.AddEssentialInfo(ref nl, "labels:" + node.Labels.ToString());
      // OurLine.AddEssentialInfo(ref nl, node.Labels.Select((l) => l.Value.ToString()));
      OurLine.AddEssentialInfo(ref nl, "statements:" + node.Statements.ToString());

      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("SwitchSection");
      base.VisitSwitchSection(node);
      EndBlock("SwitchSection");
    }

    public override void VisitStructDeclaration(StructDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("StructDeclaration"); var nl = OurLine.NewLine(LineKind.Decl, "StructDeclaration");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("StructDeclaration");
      base.VisitStructDeclaration(node);
      EndBlock("StructDeclaration");
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
      var nl = OurLine.NewLine(LineKind.Decl, "TryStatement");
      if (node.Finally != null) OurLine.AddEssentialInfo(ref nl, "finally:" + node.Finally.ToString());
      if (node.Catches != null) OurLine.AddEssentialInfo(ref nl, "catches:" + node.Catches.ToString());
      // we get the details later on.
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

      StartBlock("SwitchStatement");
      base.VisitSwitchStatement(node);
      EndBlock("SwitchStatement");
    }
    public override void VisitCatchClause(CatchClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "CatchClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("CatchClause");
      base.VisitCatchClause(node);
      EndBlock("CatchClause");
    }

    public override void VisitAccessorDeclaration(AccessorDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "AccessorDeclaration");
      var stms = node?.Body?.Statements.Select((x) => x.ToString());
      OurLine.AddEssentialInfo(ref nl, "keyword:" + node.Keyword.Text);
      if (stms != null)
      {
        var statements = string.Join("###", stms);
        OurLine.AddEssentialInfo(ref nl, "statements:" + statements);
      }

      OurLine.AddEssentialInfo(ref nl, "modifiers:" + node.Modifiers.ToString());
      OurLine.AddEssentialInfo(ref nl, "expressionBody:" + node.ExpressionBody?.ToString() ?? "");
      nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("AccessorDeclaration");
      base.VisitAccessorDeclaration(node);
      EndBlock("AccessorDeclaration");
    }

    public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ConstructorDeclaration");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, "name:" + node.Identifier.Text);
      OurLine.AddEssentialInfo(ref nl, "modifiers:" + node.Modifiers.ToString());
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("ConstructorDeclaration");
      base.VisitConstructorDeclaration(node);
      EndBlock("ConstructorDeclaration");
    }
    public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("DestructorDeclaration"); var nl = OurLine.NewLine(LineKind.Decl, "DestructorDeclaration");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("DestructorDeclaration");
      base.VisitDestructorDeclaration(node);
      EndBlock("DestructorDeclaration");
    }
    public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "IndexerDeclaration");
      // relevant parts: accessor list, interface specifier, parameterlist, maybe modifiers maybe expressionbody
      if (node.ExplicitInterfaceSpecifier != null)
        OurLine.AddEssentialInfo(ref nl, "explicitInterfaceSpecifier:" + node.ExplicitInterfaceSpecifier.ToString());
      if (node.ParameterList != null)
        OurLine.AddEssentialInfo(ref nl, "parameterList:" + node.ParameterList.ToString());
      if (node.AccessorList != null)
        OurLine.AddEssentialInfo(ref nl, "accessorList:" + node.AccessorList.ToString());
      if (node.Modifiers != null)
        OurLine.AddEssentialInfo(ref nl, "modifiers:" + node.Modifiers.ToString());
      if (node.ExpressionBody != null)
        OurLine.AddEssentialInfo(ref nl, "expressionBody:" + node.ExpressionBody.ToString());

      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      StartBlock("IndexerDeclaration");
      base.VisitIndexerDeclaration(node);
      EndBlock("IndexerDeclaration");
    }
    public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("AnonymousMethodExpression"); var nl = OurLine.NewLine(LineKind.Decl, "AnonymousMethodExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("AnonymousMethodExpression");
      base.VisitAnonymousMethodExpression(node);
      EndBlock("AnonymousMethodExpression");
    }

    public override void VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ConversionOperatorDeclaration"); var nl = OurLine.NewLine(LineKind.Decl, "ConversionOperatorDeclaration");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      StartBlock("ConversionOperatorDeclaration");
      base.VisitConversionOperatorDeclaration(node);
      EndBlock("ConversionOperatorDeclaration");
    }
    public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("SimpleLambdaExpression"); var nl = OurLine.NewLine(LineKind.Decl, "SimpleLambdaExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("SimpleLambdaExpression");

      StartBlock("SimpleLambdaExpression");
      base.VisitSimpleLambdaExpression(node);
      EndBlock("SimpleLambdaExpression");
    }

    public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ParenthesizedLambdaExpression"); var nl = OurLine.NewLine(LineKind.Decl, "ParenthesizedLambdaExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("ParenthesizedLambdaExpression");

      StartBlock("ParenthesizedLambdaExpression");
      base.VisitParenthesizedLambdaExpression(node);
      EndBlock("ParenthesizedLambdaExpression");
    }

    public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("OperatorDeclaration"); var nl = OurLine.NewLine(LineKind.Decl, "OperatorDeclaration");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("OperatorDeclaration");

      StartBlock("OperatorDeclaration");
      base.VisitOperatorDeclaration(node);
      EndBlock("OperatorDeclaration");
    }
  }
}