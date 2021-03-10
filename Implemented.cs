// VisitCSharp.cs

using System;
// using System.Collections.Generic;
using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CsDisplay
{
  internal partial class VisitCSharp : CSharpSyntaxWalker
  {


    public override void VisitBinaryExpression(BinaryExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "BinaryExpression");
      OurLine.AddEssentialInfo(ref nl, "left:" + node.Left.ToString());
      OurLine.AddEssentialInfo(ref nl, "op:" + node.OperatorToken.ToString());
      OurLine.AddEssentialInfo(ref nl, "right:" + node.Right.ToString());

      if (debug) System.Console.WriteLine(node.Parent.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitBinaryExpression(node);
    }
    // TODO: well, we probably have the same info later on, with MemberAccessExpression etc.
    public override void VisitInvocationExpression(InvocationExpressionSyntax node)
    {
      var expr = node.Expression;
      // var argList = node.ArgumentList;

      var nl = OurLine.NewLine(LineKind.Decl, "InvocationExpression");
      OurLine.AddEssentialInfo(ref nl, "expression:" + expr.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;

      LogCommand(nl);
      base.VisitInvocationExpression(node);
    }
    public override void VisitCompilationUnit(CompilationUnitSyntax node)
    {
      base.VisitCompilationUnit(node);
    }

    public override void VisitTypeArgumentList(TypeArgumentListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "TypeArgumentList");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, "arguments:" + node.Arguments.ToString());
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      base.VisitTypeArgumentList(node);
    }
    public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ObjectCreationExpression");
      OurLine.AddEssentialInfo(ref nl, "type:" + node.Type.ToString());
      // # the rest come later. (i think)
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitObjectCreationExpression(node);
    }

    public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "EnumMemberDeclaration");
      OurLine.AddEssentialInfo(ref nl, "name:" + node.Identifier.Text.ToString());

      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitEnumMemberDeclaration(node);
    }
    public override void VisitExplicitInterfaceSpecifier(ExplicitInterfaceSpecifierSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ExplicitInterfaceSpecifier");
      OurLine.AddEssentialInfo(ref nl, "name:" + node.Name.ToString().TrimEnd('.'));
      // System.Console.WriteLine(node.Name.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitExplicitInterfaceSpecifier(node);
    }
    public override void VisitSimpleBaseType(SimpleBaseTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "SimpleBaseType");
      OurLine.AddEssentialInfo(ref nl, "type:" + node.Type.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      base.VisitSimpleBaseType(node);
    }
    public override void VisitReturnStatement(ReturnStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ReturnStatement");
      nl.Source = node.ToFullString();
      // System.Console.WriteLine(node.Expression);
      if (node.Expression != null)
        OurLine.AddEssentialInfo(ref nl, "expression:" + node.Expression.ToString());

      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      base.VisitReturnStatement(node);
    }
    public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());

      var nl = OurLine.NewLine(LineKind.Decl, "FieldDeclaration");
      OurLine.AddEssentialInfo(ref nl, "modifiers:" + node.Modifiers.ToString());
      OurLine.AddEssentialInfo(ref nl, "type:" + node.Declaration.Type.ToString());
      OurLine.AddEssentialInfo(ref nl, "variables:" + node.Declaration.Variables.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitFieldDeclaration(node);
    }

    public override void VisitUsingDirective(UsingDirectiveSyntax node)
    {
      var name = node.Name.ToString();
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "UsingDirective");
      OurLine.AddEssentialInfo(ref nl, "name:" + name);
      OurLine.AddEssentialInfo(ref nl, "staticKeyword:" + node.StaticKeyword.Text);
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      // System.Console.WriteLine("info: " + nodeContent);
      base.VisitUsingDirective(node);
    }




    public override void VisitQualifiedName(QualifiedNameSyntax node)
    {
      var text = node.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "QualifiedName");
      OurLine.AddEssentialInfo(ref nl, "name:" + text);
      // nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitQualifiedName(node);
    }

    public override void VisitIdentifierName(IdentifierNameSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "IdentifierName");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, "name:" + node.Identifier.ToString());
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitIdentifierName(node);
    }



    public override void VisitBlock(BlockSyntax node)
    {
      base.VisitBlock(node);
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
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitVariableDeclaration(node);
    }

    public override void VisitLiteralExpression(LiteralExpressionSyntax node)
    {
      var token = node.Token.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "LiteralExpression");
      OurLine.AddEssentialInfo(ref nl, "token:" + token);
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitLiteralExpression(node);
    }

    public override void VisitArgumentList(ArgumentListSyntax node)
    {
      var args = node.Arguments.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "ArgumentList");
      OurLine.AddEssentialInfo(ref nl, "arguments:" + args);
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitArgumentList(node);
    }
    public override void VisitPredefinedType(PredefinedTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "PredefinedType");
      OurLine.AddEssentialInfo(ref nl, "keyword:" + node.Keyword.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      base.VisitPredefinedType(node);
    }

    // TODO
    public override void VisitTypeParameterList(TypeParameterListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "TypeParameterList");
      OurLine.AddEssentialInfo(ref nl, "value:" + node.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
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
      OurLine.AddEssentialInfo(ref nl, "value:" + n.ToFullString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      base.VisitArgument(node);
    }
    // TODO(mostused)
    public override void VisitExpressionStatement(ExpressionStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ExpressionStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      base.VisitExpressionStatement(node);
    }

    public override void VisitParameter(ParameterSyntax node)
    {
      var nl = OurLine.NewLine(LineKind.Decl, "Parameter");
      OurLine.AddEssentialInfo(ref nl, "name:" + node.Identifier.Text);
      OurLine.AddEssentialInfo(ref nl, "type:" + node.Type?.GetText().ToString());
      if (node.Modifiers.Count > 0)
        OurLine.AddExtraInfo(ref nl, "modifiers:" + node.Modifiers.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitParameter(node);
    }

    // TODO(mostused)
    public override void VisitAssignmentExpression(AssignmentExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "AssignmentExpression");
      OurLine.AddEssentialInfo(ref nl, "left:" + node.Left.ToString());
      OurLine.AddEssentialInfo(ref nl, "op:" + node.OperatorToken.ToString());
      OurLine.AddEssentialInfo(ref nl, "right:" + node.Right.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      base.VisitAssignmentExpression(node);
    }
    // TODO(mostused)
    public override void VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "LocalDeclarationStatement");
      var typ = node.Declaration.Type.ToString();
      var names = node.Declaration.Variables.Select((x) => x.Identifier.Text).ToList();
      // left hand side comes later.
      OurLine.AddEssentialInfo(ref nl, "names:" + string.Join(", ", names));
      OurLine.AddEssentialInfo(ref nl, "type:" + typ);

      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitLocalDeclarationStatement(node);
    }




    public override void VisitBaseList(BaseListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "BaseList");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, node.Types.ToString());
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitBaseList(node);
    }

    public override void VisitGenericName(GenericNameSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "GenericName");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, node.Arity.ToString());
      OurLine.AddEssentialInfo(ref nl, node.Identifier.ToString());
      OurLine.AddEssentialInfo(ref nl, node.TypeArgumentList.ToString());
      OurLine.AddEssentialInfo(ref nl, node.TypeArgumentList.Arguments.ToString());

      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitGenericName(node);
    }

    public override void VisitAttribute(AttributeSyntax node)
    {
      // not interested in supporting this!
      base.VisitAttribute(node);
    }

    public override void VisitAttributeArgument(AttributeArgumentSyntax node)
    {
      // not interested in supporting this!
      base.VisitAttributeArgument(node);
    }

    public override void VisitAttributeArgumentList(AttributeArgumentListSyntax node)
    {
      // not interested in supporting this!
      base.VisitAttributeArgumentList(node);
    }

    public override void VisitAttributeList(AttributeListSyntax node)
    {
      // I don't want to support this.
      base.VisitAttributeList(node);
    }

    public override void VisitAttributeTargetSpecifier(AttributeTargetSpecifierSyntax node)
    {
      // not interested in supporting this!
      base.VisitAttributeTargetSpecifier(node);
    }




  }
}