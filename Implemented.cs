// VisitCSharp.cs

using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CsDisplay
{
  internal partial class VisitCSharp : CSharpSyntaxWalker
  {


    // TODO: well, we probably have the same info later on, with MemberAccessExpression etc.
    public override void VisitInvocationExpression(InvocationExpressionSyntax node)
    {
      var expr = node.Expression;
      // var argList = node.ArgumentList;

      var nl = OurLine.NewLine(LineKind.Decl, "InvocationExpression");
      OurLine.AddEssentialInfo(ref nl, expr.ToString());
      nl.Source = node.ToFullString();
      LogCommand(nl);
      base.VisitInvocationExpression(node);
    }
    public override void VisitCompilationUnit(CompilationUnitSyntax node)
    {
      base.VisitCompilationUnit(node);
    }
    public override void VisitUsingDirective(UsingDirectiveSyntax node)
    {
      var name = node.Name.ToString();
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "UsingDirective");
      OurLine.AddEssentialInfo(ref nl, name);
      nl.Source = node.ToFullString();
      LogCommand(nl);

      // System.Console.WriteLine("info: " + nodeContent);
      base.VisitUsingDirective(node);
    }
    public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
    {
      StartBlock(); // worked wonderfully!

      var name = node.Name.ToString();
      // currentNamespace = null;
      var nl = OurLine.NewLine(LineKind.Decl, "NamespaceDeclaration");
      OurLine.AddEssentialInfo(ref nl, name);
      nl.Source = node.ToFullString();
      LogCommand(nl);
      // currentNamespace = node;
      base.VisitNamespaceDeclaration(node);

      EndBlock(); // god is good!

    }

    public override void VisitQualifiedName(QualifiedNameSyntax node)
    {
      var text = node.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "QualifiedName");
      OurLine.AddEssentialInfo(ref nl, text);
      nl.Source = node.ToFullString();
      LogCommand(nl);
      base.VisitQualifiedName(node);
    }

    public override void VisitClassDeclaration(ClassDeclarationSyntax node)
    {
      StartBlock();
      var clsname = node.Identifier.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "ClassDeclaration");
      OurLine.AddEssentialInfo(ref nl, clsname);
      nl.Source = node.ToFullString();
      LogCommand(nl);
      // currentClass = node;
      var modifiers = node.Modifiers; // TODO

      base.VisitClassDeclaration(node);
      EndBlock();
    }

    public override void VisitIdentifierName(IdentifierNameSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "IdentifierName");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, node.Identifier.ToString());
      LogCommand(nl);
      base.VisitIdentifierName(node);
    }
    public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
      StartBlock();
      var name = node.Identifier.ToString();
      var arity = node.Arity;
      var nl = OurLine.NewLine(LineKind.Decl, "MethodDeclaration");
      OurLine.AddEssentialInfo(ref nl, name + "/" + arity.ToString());
      nl.Source = node.ToFullString();
      LogCommand(nl);
      // currentMethod = node;
      base.VisitMethodDeclaration(node);
      EndBlock();
    }


    public override void VisitBlock(BlockSyntax node)
    {
      StartBlock();
      base.VisitBlock(node);
      EndBlock();
    }


    public override void VisitVariableDeclaration(VariableDeclarationSyntax node)
    {
      var t = node.Type.ToString();
      var vars = node.Variables;
      var varName = vars[0].Identifier.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "VariableDeclaration");
      OurLine.AddEssentialInfo(ref nl, "type:" + t);
      OurLine.AddEssentialInfo(ref nl, "name:" + varName);
      nl.Source = node.ToFullString();
      LogCommand(nl);
      base.VisitVariableDeclaration(node);
    }

    public override void VisitLiteralExpression(LiteralExpressionSyntax node)
    {
      var token = node.Token.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "LiteralExpression");
      OurLine.AddEssentialInfo(ref nl, token);
      nl.Source = node.ToFullString();
      LogCommand(nl);
      base.VisitLiteralExpression(node);
    }

    public override void VisitArgumentList(ArgumentListSyntax node)
    {
      var args = node.Arguments.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "ArgumentList");
      OurLine.AddEssentialInfo(ref nl, args);
      nl.Source = node.ToFullString();
      LogCommand(nl);
      base.VisitArgumentList(node);
    }
    public override void VisitPredefinedType(PredefinedTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "PredefinedType");
      OurLine.AddEssentialInfo(ref nl, node.Keyword.ToString());
      nl.Source = node.ToFullString();
      LogCommand(nl);

      base.VisitPredefinedType(node);
    }

    // TODO
    public override void VisitTypeParameterList(TypeParameterListSyntax node)
    {
      Todo("TypeParameterList");
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "TypeParameterList");
      OurLine.AddEssentialInfo(ref nl, node.ToString());
      nl.Source = node.ToFullString();
      LogCommand(nl);

      base.VisitTypeParameterList(node);
    }

    // TODO(mostused)
    public override void VisitArgument(ArgumentSyntax node)
    {
      // System.Console.WriteLine("IN ARGUMENT");
      // Console.WriteLine(node.ToFullString());
      // Console.WriteLine(   node.NameColon);
      // Console.WriteLine(   node.RefKindKeyword);
      var n = node.Expression;
      // Console.WriteLine(n.KindText);
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "Argument");
      OurLine.AddEssentialInfo(ref nl, n.ToFullString());
      nl.Source = node.ToFullString();
      LogCommand(nl);
      // Todo("Argument");

      base.VisitArgument(node);
    }
    // TODO(mostused)
    public override void VisitExpressionStatement(ExpressionStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      // System.Console.WriteLine(node.Expression.ToString(), node.AttributeLists);
      var nl = OurLine.NewLine(LineKind.Decl, "ExpressionStatement");
      nl.Source = node.ToFullString();
      LogCommand(nl);
      // Todo("ExpressionStatement");

      base.VisitExpressionStatement(node);
    }
    public override void VisitParameter(ParameterSyntax node)
    {
      var nl = OurLine.NewLine(LineKind.Decl, "Parameter");
      OurLine.AddEssentialInfo(ref nl, node.ToFullString());
      if (node.Modifiers.Count > 0)
        OurLine.AddExtraInfo(ref nl, node.Modifiers.ToString());
      nl.Source = node.ToFullString();
      LogCommand(nl);


      base.VisitParameter(node);
    }
    // TODO(mostused)
    public override void VisitAssignmentExpression(AssignmentExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "AssignmentExpression");
      OurLine.AddEssentialInfo(ref nl, node.Left.ToString());
      OurLine.AddEssentialInfo(ref nl, node.OperatorToken.ToString());
      OurLine.AddEssentialInfo(ref nl, node.Right.ToString());
      nl.Source = node.ToFullString();
      LogCommand(nl);
      Todo("ParameterList");

      base.VisitAssignmentExpression(node);
    }
    // TODO(mostused)
    public override void VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "LocalDeclarationStatement");
      OurLine.AddEssentialInfo(ref nl, node.ToString());
      nl.Source = node.ToFullString();
      LogCommand(nl);
      base.VisitLocalDeclarationStatement(node);
    }

    public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
    {
      StartBlock();
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "EnumDeclaration");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, node.Identifier.Text.ToString());
      System.Console.WriteLine(nl);
      LogCommand(nl);
      base.VisitEnumDeclaration(node);
      EndBlock();
    }

    // TODO(mostused)
    public override void VisitIfStatement(IfStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "IfStatement");
      nl.Source = node.ToFullString();
      LogCommand(nl);
      Todo("IfStatement");

      base.VisitIfStatement(node);
    }

  }
}