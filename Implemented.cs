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
      OurLine.AddEssentialInfo(ref nl, node.Left.ToString());
      OurLine.AddEssentialInfo(ref nl, node.OperatorToken.ToString());
      OurLine.AddEssentialInfo(ref nl, node.Right.ToString());

      System.Console.WriteLine(node.Parent.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitBinaryExpression(node);
    }
    // TODO: well, we probably have the same info later on, with MemberAccessExpression etc.
    public override void VisitInvocationExpression(InvocationExpressionSyntax node)
    {
      var expr = node.Expression;
      // var argList = node.ArgumentList;

      var nl = OurLine.NewLine(LineKind.Decl, "InvocationExpression");
      OurLine.AddEssentialInfo(ref nl, expr.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitInvocationExpression(node);
    }
    public override void VisitCompilationUnit(CompilationUnitSyntax node)
    {
      base.VisitCompilationUnit(node);
    }

    public override void VisitSwitchSection(SwitchSectionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "SwitchSection");
      OurLine.AddEssentialInfo(ref nl, node.Labels.ToString());
      // OurLine.AddEssentialInfo(ref nl, node.Labels.Select((l) => l.Value.ToString()));
      OurLine.AddEssentialInfo(ref nl, node.Statements.ToString());

      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);

      base.VisitSwitchSection(node);
    }
    public override void VisitTypeArgumentList(TypeArgumentListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "TypeArgumentList");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, node.Arguments.ToString());
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);

      base.VisitTypeArgumentList(node);
    }
    public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ObjectCreationExpression");
      OurLine.AddEssentialInfo(ref nl, node.Type.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitObjectCreationExpression(node);
    }
    public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ConstructorDeclaration");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, node.Identifier.Text);
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitConstructorDeclaration(node);
    }
    public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "EnumMemberDeclaration");
      OurLine.AddEssentialInfo(ref nl, node.Identifier.Text.ToString());

      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitEnumMemberDeclaration(node);
    }
    public override void VisitExplicitInterfaceSpecifier(ExplicitInterfaceSpecifierSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ExplicitInterfaceSpecifier");
      OurLine.AddEssentialInfo(ref nl, node.Name.ToString().TrimEnd('.'));
      // System.Console.WriteLine(node.Name.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitExplicitInterfaceSpecifier(node);
    }
    public override void VisitSimpleBaseType(SimpleBaseTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "SimpleBaseType");
      OurLine.AddEssentialInfo(ref nl, node.Type.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
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
        OurLine.AddEssentialInfo(ref nl, node.Expression.ToString());

      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);

      base.VisitReturnStatement(node);
    }
    public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());

      var nl = OurLine.NewLine(LineKind.Decl, "FieldDeclaration");
      OurLine.AddEssentialInfo(ref nl, node.Modifiers.ToString());
      OurLine.AddEssentialInfo(ref nl, node.Declaration.Type.ToString());
      OurLine.AddEssentialInfo(ref nl, node.Declaration.Variables.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitFieldDeclaration(node);
    }

    public override void VisitUsingDirective(UsingDirectiveSyntax node)
    {
      var name = node.Name.ToString();
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "UsingDirective");
      OurLine.AddEssentialInfo(ref nl, name);
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);

      // System.Console.WriteLine("info: " + nodeContent);
      base.VisitUsingDirective(node);
    }

    public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
      StartBlock("PropertyDeclaration");

      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "PropertyDeclaration");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, node?.Identifier.Text.ToString());

      var cnt = node?.AccessorList?.Accessors.Count.ToString();
      int count;
      if (cnt == null)
        count = 0;
      else
        count = int.Parse(cnt);

      OurLine.AddEssentialInfo(ref nl, node?.AccessorList?.Accessors.Count.ToString());

      if (count > 0)
        OurLine.AddExtraInfo(ref nl, node?.AccessorList?.Accessors[0].Keyword.Text);
      if (count > 1)
        OurLine.AddExtraInfo(ref nl, node?.AccessorList?.Accessors[1].Keyword.Text);
      // sometimes has body etc..
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitPropertyDeclaration(node);
      EndBlock();
    }

    public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
    {
      StartBlock("NamespaceDeclaration"); // worked wonderfully!

      var name = node.Name.ToString();
      // currentNamespace = null;
      var nl = OurLine.NewLine(LineKind.Decl, "NamespaceDeclaration");
      OurLine.AddEssentialInfo(ref nl, name);
      // nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
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
      // nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitQualifiedName(node);
    }

    public override void VisitClassDeclaration(ClassDeclarationSyntax node)
    {
      StartBlock("ClassDeclaration");
      var clsname = node.Identifier.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "ClassDeclaration");
      OurLine.AddEssentialInfo(ref nl, clsname);
      if (node.BaseList != null)
      {
        var baseTypes = node.BaseList.Types.ToString(); //.Select((t) => t.Type.Identifier.Text.ToString()).Join(", ");
        System.Console.WriteLine(baseTypes);
        OurLine.AddEssentialInfo(ref nl, baseTypes);
      }
      // nl.Source = node.ToFullString();
      // currentClass = node;
      var modifiers = node.Modifiers;
      OurLine.AddExtraInfo(ref nl, modifiers.ToString());

      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitClassDeclaration(node);
      EndBlock();
    }

    public override void VisitIdentifierName(IdentifierNameSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "IdentifierName");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, node.Identifier.ToString());
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitIdentifierName(node);
    }
    public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
      StartBlock("MethodDeclaration");
      var name = node.Identifier.ToString();
      var arity = node.ParameterList.Parameters.Count;
      var nl = OurLine.NewLine(LineKind.Decl, "MethodDeclaration");
      var mod = node.Modifiers.ToString();
      var ret = node.ReturnType.ToString();
      OurLine.AddEssentialInfo(ref nl, name);
      OurLine.AddEssentialInfo(ref nl, ret);
      OurLine.AddExtraInfo(ref nl, mod);
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      // currentMethod = node;
      base.VisitMethodDeclaration(node);
      EndBlock();
    }


    public override void VisitBlock(BlockSyntax node)
    {
      // StartBlock("VisitBlock");
      base.VisitBlock(node);
      // EndBlock();
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
      LogCommand(nl);
      base.VisitVariableDeclaration(node);
    }

    public override void VisitLiteralExpression(LiteralExpressionSyntax node)
    {
      var token = node.Token.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "LiteralExpression");
      OurLine.AddEssentialInfo(ref nl, token);
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitLiteralExpression(node);
    }

    public override void VisitArgumentList(ArgumentListSyntax node)
    {
      var args = node.Arguments.ToString();
      var nl = OurLine.NewLine(LineKind.Decl, "ArgumentList");
      OurLine.AddEssentialInfo(ref nl, args);
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitArgumentList(node);
    }
    public override void VisitPredefinedType(PredefinedTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "PredefinedType");
      OurLine.AddEssentialInfo(ref nl, node.Keyword.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);

      base.VisitPredefinedType(node);
    }

    // TODO
    public override void VisitTypeParameterList(TypeParameterListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "TypeParameterList");
      OurLine.AddEssentialInfo(ref nl, node.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
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
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);

      base.VisitArgument(node);
    }
    // TODO(mostused)
    public override void VisitExpressionStatement(ExpressionStatementSyntax node)
    {
      StartBlock("ExpressionStatement");
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ExpressionStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);

      base.VisitExpressionStatement(node);
      EndBlock();
    }

    public override void VisitParameter(ParameterSyntax node)
    {
      var nl = OurLine.NewLine(LineKind.Decl, "Parameter");
      OurLine.AddEssentialInfo(ref nl, node.Identifier.Text);
      OurLine.AddEssentialInfo(ref nl, node.Type?.GetText().ToString());
      if (node.Modifiers.Count > 0)
        OurLine.AddExtraInfo(ref nl, node.Modifiers.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
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
      nl.ParentKind = node.Parent.RawKind;
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
      OurLine.AddEssentialInfo(ref nl, string.Join(", ", names));
      OurLine.AddEssentialInfo(ref nl, typ);

      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitLocalDeclarationStatement(node);
    }

    public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
    {
      StartBlock("EnumDeclaration");
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "EnumDeclaration");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, node.Identifier.Text.ToString());
      // System.Console.WriteLine(nl);
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);
      base.VisitEnumDeclaration(node);
      EndBlock();
    }

    // TODO(mostused)
    public override void VisitIfStatement(IfStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "IfStatement");
      // condition, statement, else.statement
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, node.Condition.ToString());
      OurLine.AddEssentialInfo(ref nl, node.Statement.ToString());
      var elsey = node.Else?.Statement;
      if (elsey != null)
        OurLine.AddEssentialInfo(ref nl, elsey.ToString());


      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);

      base.VisitIfStatement(node);
    }


    public override void VisitBaseList(BaseListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "BaseList");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, node.Types.ToString());
      nl.ParentKind = node.Parent.RawKind;
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
      LogCommand(nl);
      base.VisitGenericName(node);
    }

    public override void VisitAttribute(AttributeSyntax node)
    {
      // not interested in supporting this!
      // if (debug) Console.WriteLine(node.ToFullString());
      // var nl = OurLine.NewLine(LineKind.Decl, "Attribute");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // LogCommand(nl);
      base.VisitAttribute(node);
    }

    public override void VisitAttributeArgument(AttributeArgumentSyntax node)
    {
      // not interested in supporting this!
      // if (debug) Console.WriteLine(node.ToFullString());
      // var nl = OurLine.NewLine(LineKind.Decl, "AttributeArgument");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // LogCommand(nl);
      base.VisitAttributeArgument(node);
    }

    public override void VisitAttributeArgumentList(AttributeArgumentListSyntax node)
    {
      // not interested in supporting this!
      // if (debug) Console.WriteLine(node.ToFullString());
      // var nl = OurLine.NewLine(LineKind.Decl, "AttributeArgumentList");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // LogCommand(nl);
      base.VisitAttributeArgumentList(node);
    }

    public override void VisitAttributeList(AttributeListSyntax node)
    {
      // I don't want to support this.

      // if (debug) Console.WriteLine(node.ToFullString());
      // var nl = OurLine.NewLine(LineKind.Decl, "AttributeList");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // LogCommand(nl);
      base.VisitAttributeList(node);
    }
    public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "IndexerDeclaration");
      // relevant parts: accessor list, interface specifier, parameterlist, maybe modifiers maybe expressionbody
      if (node.ExplicitInterfaceSpecifier != null)
        OurLine.AddEssentialInfo(ref nl, node.ExplicitInterfaceSpecifier.ToString());
      if (node.ParameterList != null)
        OurLine.AddEssentialInfo(ref nl, node.ParameterList.ToString());
      if (node.AccessorList != null)
        OurLine.AddEssentialInfo(ref nl, node.AccessorList.ToString());
      if (node.Modifiers != null)
        OurLine.AddEssentialInfo(ref nl, node.Modifiers.ToString());
      if (node.ExpressionBody != null)
        OurLine.AddEssentialInfo(ref nl, node?.ExpressionBody.ToString());

      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      LogCommand(nl);

      base.VisitIndexerDeclaration(node);
    }
    public override void VisitAttributeTargetSpecifier(AttributeTargetSpecifierSyntax node)
    {
      // not interested in supporting this!
      // if (debug) Console.WriteLine(node.ToFullString());
      // var nl = OurLine.NewLine(LineKind.Decl, "AttributeTargetSpecifier");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      base.VisitAttributeTargetSpecifier(node);
    }

  }
}