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
    public Dictionary<string, int> counter = new Dictionary<string, int>();
    public void Todo(string str)
    {
      Dictionary<string, int> c;
      if (Program.dir) c = Program.counter;
      else c = this.counter;

      // Console.WriteLine("NodeInfo: TODO");
      if (!c.ContainsKey(str))
      {
        c[str] = 1;
      }
      else
      {
        c[str]++;
      }
    }






    public override void VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ImplicitArrayCreationExpression"); var nl = OurLine.NewLine(LineKind.Decl, "ImplicitArrayCreationExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("ImplicitArrayCreationExpression");

      base.VisitImplicitArrayCreationExpression(node);
    }
    public override void VisitImplicitElementAccess(ImplicitElementAccessSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ImplicitElementAccess"); var nl = OurLine.NewLine(LineKind.Decl, "ImplicitElementAccess");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("ImplicitElementAccess");

      base.VisitImplicitElementAccess(node);
    }
    public override void VisitImplicitStackAllocArrayCreationExpression(ImplicitStackAllocArrayCreationExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ImplicitStackAllocArrayCreationExpression"); var nl = OurLine.NewLine(LineKind.Decl, "ImplicitStackAllocArrayCreationExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("ImplicitStackAllocArrayCreationExpression");

      base.VisitImplicitStackAllocArrayCreationExpression(node);
    }
    public override void VisitIncompleteMember(IncompleteMemberSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("IncompleteMember"); var nl = OurLine.NewLine(LineKind.Decl, "IncompleteMember");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("IncompleteMember");

      base.VisitIncompleteMember(node);
    }

    public override void VisitIndexerMemberCref(IndexerMemberCrefSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("IndexerMemberCref"); var nl = OurLine.NewLine(LineKind.Decl, "IndexerMemberCref");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("IndexerMemberCref");

      base.VisitIndexerMemberCref(node);
    }
    public override void VisitInitializerExpression(InitializerExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "InitializerExpression");
      OurLine.AddEssentialInfo(ref nl, "count:" + node.Expressions.Count.ToString());
      OurLine.AddEssentialInfo(ref nl, "expressions:" + node.Expressions.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);

      base.VisitInitializerExpression(node);
    }
    public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("InterfaceDeclaration"); var nl = OurLine.NewLine(LineKind.Decl, "InterfaceDeclaration");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("InterfaceDeclaration");

      base.VisitInterfaceDeclaration(node);
    }
    public override void VisitInterpolatedStringExpression(InterpolatedStringExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("InterpolatedStringExpression"); var nl = OurLine.NewLine(LineKind.Decl, "InterpolatedStringExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("InterpolatedStringExpression");

      base.VisitInterpolatedStringExpression(node);
    }
    public override void VisitInterpolatedStringText(InterpolatedStringTextSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("InterpolatedStringText"); var nl = OurLine.NewLine(LineKind.Decl, "InterpolatedStringText");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("InterpolatedStringText");

      base.VisitInterpolatedStringText(node);
    }
    public override void VisitInterpolation(InterpolationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("Interpolation"); var nl = OurLine.NewLine(LineKind.Decl, "Interpolation");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("Interpolation");

      base.VisitInterpolation(node);
    }
    public override void VisitInterpolationAlignmentClause(InterpolationAlignmentClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("InterpolationAlignmentClause"); var nl = OurLine.NewLine(LineKind.Decl, "InterpolationAlignmentClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("InterpolationAlignmentClause");

      base.VisitInterpolationAlignmentClause(node);
    }
    public override void VisitInterpolationFormatClause(InterpolationFormatClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("InterpolationFormatClause"); var nl = OurLine.NewLine(LineKind.Decl, "InterpolationFormatClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("InterpolationFormatClause");

      base.VisitInterpolationFormatClause(node);
    }

    public override void VisitIsPatternExpression(IsPatternExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("IsPatternExpression"); var nl = OurLine.NewLine(LineKind.Decl, "IsPatternExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("IsPatternExpression");

      base.VisitIsPatternExpression(node);
    }
    public override void VisitJoinClause(JoinClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("JoinClause"); var nl = OurLine.NewLine(LineKind.Decl, "JoinClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("JoinClause");

      base.VisitJoinClause(node);
    }
    public override void VisitJoinIntoClause(JoinIntoClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("JoinIntoClause"); var nl = OurLine.NewLine(LineKind.Decl, "JoinIntoClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("JoinIntoClause");

      base.VisitJoinIntoClause(node);
    }
    public override void VisitLabeledStatement(LabeledStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("LabeledStatement"); var nl = OurLine.NewLine(LineKind.Decl, "LabeledStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("LabeledStatement");

      base.VisitLabeledStatement(node);
    }
    public override void VisitLetClause(LetClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("LetClause"); var nl = OurLine.NewLine(LineKind.Decl, "LetClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("LetClause");

      base.VisitLetClause(node);
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

      base.VisitLocalFunctionStatement(node);
    }

    public override void VisitMakeRefExpression(MakeRefExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("MakeRefExpression"); var nl = OurLine.NewLine(LineKind.Decl, "MakeRefExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("MakeRefExpression");

      base.VisitMakeRefExpression(node);
    }

    public override void VisitMemberBindingExpression(MemberBindingExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("MemberBindingExpression"); var nl = OurLine.NewLine(LineKind.Decl, "MemberBindingExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("MemberBindingExpression");

      base.VisitMemberBindingExpression(node);
    }

    public override void VisitNameColon(NameColonSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("NameColon"); var nl = OurLine.NewLine(LineKind.Decl, "NameColon");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("NameColon");

      base.VisitNameColon(node);
    }
    public override void VisitNameEquals(NameEqualsSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("NameEquals"); var nl = OurLine.NewLine(LineKind.Decl, "NameEquals");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("NameEquals");

      base.VisitNameEquals(node);
    }
    public override void VisitNameMemberCref(NameMemberCrefSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("NameMemberCref"); var nl = OurLine.NewLine(LineKind.Decl, "NameMemberCref");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("NameMemberCref");

      base.VisitNameMemberCref(node);
    }

    public override void VisitNullableType(NullableTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("NullableType"); var nl = OurLine.NewLine(LineKind.Decl, "NullableType");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("NullableType");

      base.VisitNullableType(node);
    }

    public override void VisitOmittedArraySizeExpression(OmittedArraySizeExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("OmittedArraySizeExpression"); var nl = OurLine.NewLine(LineKind.Decl, "OmittedArraySizeExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("OmittedArraySizeExpression");

      base.VisitOmittedArraySizeExpression(node);
    }
    public override void VisitOmittedTypeArgument(OmittedTypeArgumentSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("OmittedTypeArgument"); var nl = OurLine.NewLine(LineKind.Decl, "OmittedTypeArgument");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("OmittedTypeArgument");

      base.VisitOmittedTypeArgument(node);
    }

    public override void VisitOperatorMemberCref(OperatorMemberCrefSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("OperatorMemberCref"); var nl = OurLine.NewLine(LineKind.Decl, "OperatorMemberCref");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("OperatorMemberCref");

      base.VisitOperatorMemberCref(node);
    }
    public override void VisitOrderByClause(OrderByClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("OrderByClause"); var nl = OurLine.NewLine(LineKind.Decl, "OrderByClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("OrderByClause");

      base.VisitOrderByClause(node);
    }
    public override void VisitOrdering(OrderingSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("Ordering"); var nl = OurLine.NewLine(LineKind.Decl, "Ordering");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("Ordering");

      base.VisitOrdering(node);
    }


    public override void VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ParenthesizedExpression"); var nl = OurLine.NewLine(LineKind.Decl, "ParenthesizedExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      // Todo("ParenthesizedExpression");
      // note: I think nothing is needed to be done here, can accept code as is.

      base.VisitParenthesizedExpression(node);
    }

    public override void VisitParenthesizedVariableDesignation(ParenthesizedVariableDesignationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ParenthesizedVariableDesignation"); var nl = OurLine.NewLine(LineKind.Decl, "ParenthesizedVariableDesignation");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("ParenthesizedVariableDesignation");

      base.VisitParenthesizedVariableDesignation(node);
    }
    public override void VisitPointerType(PointerTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("PointerType"); var nl = OurLine.NewLine(LineKind.Decl, "PointerType");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("PointerType");

      base.VisitPointerType(node);
    }
    public override void VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("PostfixUnaryExpression"); var nl = OurLine.NewLine(LineKind.Decl, "PostfixUnaryExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("PostfixUnaryExpression");

      base.VisitPostfixUnaryExpression(node);
    }


    public override void VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "PrefixUnaryExpression");
      OurLine.AddEssentialInfo(ref nl, "optoken:" + node.OperatorToken.ToString());
      OurLine.AddEssentialInfo(ref nl, "operand:" + node.Operand.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitPrefixUnaryExpression(node);
    }

    public override void VisitQualifiedCref(QualifiedCrefSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("QualifiedCref"); var nl = OurLine.NewLine(LineKind.Decl, "QualifiedCref");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("QualifiedCref");

      base.VisitQualifiedCref(node);
    }

    public override void VisitQueryBody(QueryBodySyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("QueryBody"); var nl = OurLine.NewLine(LineKind.Decl, "QueryBody");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("QueryBody");

      base.VisitQueryBody(node);
    }
    public override void VisitQueryContinuation(QueryContinuationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("QueryContinuation"); var nl = OurLine.NewLine(LineKind.Decl, "QueryContinuation");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("QueryContinuation");

      base.VisitQueryContinuation(node);
    }
    public override void VisitQueryExpression(QueryExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("QueryExpression"); var nl = OurLine.NewLine(LineKind.Decl, "QueryExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("QueryExpression");

      base.VisitQueryExpression(node);
    }

    public override void VisitRefExpression(RefExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("RefExpression"); var nl = OurLine.NewLine(LineKind.Decl, "RefExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("RefExpression");

      base.VisitRefExpression(node);
    }
    public override void VisitRefType(RefTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("RefType"); var nl = OurLine.NewLine(LineKind.Decl, "RefType");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("RefType");

      base.VisitRefType(node);
    }
    public override void VisitRefTypeExpression(RefTypeExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("RefTypeExpression"); var nl = OurLine.NewLine(LineKind.Decl, "RefTypeExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("RefTypeExpression");

      base.VisitRefTypeExpression(node);
    }
    public override void VisitRefValueExpression(RefValueExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("RefValueExpression"); var nl = OurLine.NewLine(LineKind.Decl, "RefValueExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("RefValueExpression");

      base.VisitRefValueExpression(node);
    }


    public override void VisitSelectClause(SelectClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("SelectClause"); var nl = OurLine.NewLine(LineKind.Decl, "SelectClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("SelectClause");

      base.VisitSelectClause(node);
    }



    public override void VisitSingleVariableDesignation(SingleVariableDesignationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("SingleVariableDesignation"); var nl = OurLine.NewLine(LineKind.Decl, "SingleVariableDesignation");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("SingleVariableDesignation");

      base.VisitSingleVariableDesignation(node);
    }
    public override void VisitSizeOfExpression(SizeOfExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("SizeOfExpression"); var nl = OurLine.NewLine(LineKind.Decl, "SizeOfExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("SizeOfExpression");

      base.VisitSizeOfExpression(node);
    }
    public override void VisitSkippedTokensTrivia(SkippedTokensTriviaSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("SkippedTokensTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "SkippedTokensTrivia");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("SkippedTokensTrivia");

      base.VisitSkippedTokensTrivia(node);
    }
    public override void VisitStackAllocArrayCreationExpression(StackAllocArrayCreationExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("StackAllocArrayCreationExpression"); var nl = OurLine.NewLine(LineKind.Decl, "StackAllocArrayCreationExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("StackAllocArrayCreationExpression");

      base.VisitStackAllocArrayCreationExpression(node);
    }


    public override void VisitThisExpression(ThisExpressionSyntax node)
    { // note: I already do that with methods, no need for special handling.
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ThisExpression"); var nl = OurLine.NewLine(LineKind.Decl, "ThisExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      // Todo("ThisExpression");

      base.VisitThisExpression(node);
    }
    public override void VisitThrowExpression(ThrowExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ThrowExpression"); var nl = OurLine.NewLine(LineKind.Decl, "ThrowExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("ThrowExpression");

      base.VisitThrowExpression(node);
    }
    public override void VisitThrowStatement(ThrowStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ThrowStatement"); var nl = OurLine.NewLine(LineKind.Decl, "ThrowStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("ThrowStatement");

      base.VisitThrowStatement(node);
    }
    public override void VisitTupleElement(TupleElementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("TupleElement"); var nl = OurLine.NewLine(LineKind.Decl, "TupleElement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("TupleElement");

      base.VisitTupleElement(node);
    }
    public override void VisitTupleExpression(TupleExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("TupleExpression"); var nl = OurLine.NewLine(LineKind.Decl, "TupleExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("TupleExpression");

      base.VisitTupleExpression(node);
    }
    public override void VisitTupleType(TupleTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("TupleType"); var nl = OurLine.NewLine(LineKind.Decl, "TupleType");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("TupleType");

      base.VisitTupleType(node);
    }

    public override void VisitTypeConstraint(TypeConstraintSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("TypeConstraint"); var nl = OurLine.NewLine(LineKind.Decl, "TypeConstraint");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("TypeConstraint");

      base.VisitTypeConstraint(node);
    }
    public override void VisitTypeCref(TypeCrefSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("TypeCref"); var nl = OurLine.NewLine(LineKind.Decl, "TypeCref");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("TypeCref");

      base.VisitTypeCref(node);
    }
    public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("TypeOfExpression"); var nl = OurLine.NewLine(LineKind.Decl, "TypeOfExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("TypeOfExpression");

      base.VisitTypeOfExpression(node);
    }
    public override void VisitTypeParameter(TypeParameterSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());

      var nl = OurLine.NewLine(LineKind.Decl, "TypeParameter");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      OurLine.AddEssentialInfo(ref nl, "varianceKeyword:" + node.VarianceKeyword.ToString());
      OurLine.AddEssentialInfo(ref nl, "identifier:" + node.Identifier.Text);

      LogCommand(nl);
      base.VisitTypeParameter(node);
    }
    public override void VisitTypeParameterConstraintClause(TypeParameterConstraintClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("TypeParameterConstraintClause"); var nl = OurLine.NewLine(LineKind.Decl, "TypeParameterConstraintClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("TypeParameterConstraintClause");

      base.VisitTypeParameterConstraintClause(node);
    }




    public override void VisitWhenClause(WhenClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("WhenClause"); var nl = OurLine.NewLine(LineKind.Decl, "WhenClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("WhenClause");

      base.VisitWhenClause(node);
    }
    public override void VisitWhereClause(WhereClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("WhereClause"); var nl = OurLine.NewLine(LineKind.Decl, "WhereClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("WhereClause");

      base.VisitWhereClause(node);
    }


    public override void VisitYieldStatement(YieldStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("YieldStatement"); var nl = OurLine.NewLine(LineKind.Decl, "YieldStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      Todo("YieldStatement");

      base.VisitYieldStatement(node);
    }

    public override void VisitAccessorList(AccessorListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "AccessorList");
      OurLine.AddEssentialInfo(ref nl, "accessors:" + node.Accessors.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitAccessorList(node);
    }

    public override void VisitAliasQualifiedName(AliasQualifiedNameSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("AliasQualifiedName"); var nl = OurLine.NewLine(LineKind.Decl, "AliasQualifiedName");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitAliasQualifiedName(node);
    }



    public override void VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("AnonymousObjectCreationExpression"); var nl = OurLine.NewLine(LineKind.Decl, "AnonymousObjectCreationExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitAnonymousObjectCreationExpression(node);
    }

    public override void VisitAnonymousObjectMemberDeclarator(AnonymousObjectMemberDeclaratorSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("AnonymousObjectMemberDeclarator"); var nl = OurLine.NewLine(LineKind.Decl, "AnonymousObjectMemberDeclarator");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitAnonymousObjectMemberDeclarator(node);
    }

    public override void VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ArrayCreationExpression"); var nl = OurLine.NewLine(LineKind.Decl, "ArrayCreationExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitArrayCreationExpression(node);
    }

    public override void VisitArrayRankSpecifier(ArrayRankSpecifierSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ArrayRankSpecifier"); var nl = OurLine.NewLine(LineKind.Decl, "ArrayRankSpecifier");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitArrayRankSpecifier(node);
    }

    public override void VisitArrayType(ArrayTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ArrayType"); var nl = OurLine.NewLine(LineKind.Decl, "ArrayType");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitArrayType(node);
    }

    public override void VisitArrowExpressionClause(ArrowExpressionClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ArrowExpressionClause"); var nl = OurLine.NewLine(LineKind.Decl, "ArrowExpressionClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitArrowExpressionClause(node);
    }

    public override void VisitAwaitExpression(AwaitExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("AwaitExpression"); var nl = OurLine.NewLine(LineKind.Decl, "AwaitExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitAwaitExpression(node);
    }



    public override void VisitBaseExpression(BaseExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("BaseExpression"); var nl = OurLine.NewLine(LineKind.Decl, "BaseExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitBaseExpression(node);
    }



    public override void VisitBinaryPattern(BinaryPatternSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("BinaryPattern"); var nl = OurLine.NewLine(LineKind.Decl, "BinaryPattern");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitBinaryPattern(node);
    }

    public override void VisitBracketedArgumentList(BracketedArgumentListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "BracketedArgumentList");
      OurLine.AddEssentialInfo(ref nl, "arguments:" + node.Arguments.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitBracketedArgumentList(node);
    }

    public override void VisitBracketedParameterList(BracketedParameterListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "BracketedParameterList");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, "parameters:" + node.Parameters.ToString());
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitBracketedParameterList(node);
    }

    public override void VisitBreakStatement(BreakStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("BreakStatement"); var nl = OurLine.NewLine(LineKind.Decl, "BreakStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitBreakStatement(node);
    }

    public override void VisitCasePatternSwitchLabel(CasePatternSwitchLabelSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("CasePatternSwitchLabel"); var nl = OurLine.NewLine(LineKind.Decl, "CasePatternSwitchLabel");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitCasePatternSwitchLabel(node);
    }

    public override void VisitCaseSwitchLabel(CaseSwitchLabelSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("CaseSwitchLabel"); var nl = OurLine.NewLine(LineKind.Decl, "CaseSwitchLabel");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitCaseSwitchLabel(node);
    }

    public override void VisitCastExpression(CastExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("CastExpression"); var nl = OurLine.NewLine(LineKind.Decl, "CastExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitCastExpression(node);
    }



    public override void VisitCatchDeclaration(CatchDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("CatchDeclaration"); var nl = OurLine.NewLine(LineKind.Decl, "CatchDeclaration");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitCatchDeclaration(node);
    }

    public override void VisitCatchFilterClause(CatchFilterClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("CatchFilterClause"); var nl = OurLine.NewLine(LineKind.Decl, "CatchFilterClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitCatchFilterClause(node);
    }

    public override void VisitCheckedExpression(CheckedExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("CheckedExpression"); var nl = OurLine.NewLine(LineKind.Decl, "CheckedExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitCheckedExpression(node);
    }


    public override void VisitClassOrStructConstraint(ClassOrStructConstraintSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ClassOrStructConstraint"); var nl = OurLine.NewLine(LineKind.Decl, "ClassOrStructConstraint");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitClassOrStructConstraint(node);
    }



    public override void VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ConditionalAccessExpression"); var nl = OurLine.NewLine(LineKind.Decl, "ConditionalAccessExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitConditionalAccessExpression(node);
    }

    public override void VisitConditionalExpression(ConditionalExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ConditionalExpression"); var nl = OurLine.NewLine(LineKind.Decl, "ConditionalExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitConditionalExpression(node);
    }

    public override void VisitConstantPattern(ConstantPatternSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ConstantPattern"); var nl = OurLine.NewLine(LineKind.Decl, "ConstantPattern");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitConstantPattern(node);
    }

    public override void VisitConstructorConstraint(ConstructorConstraintSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ConstructorConstraint"); var nl = OurLine.NewLine(LineKind.Decl, "ConstructorConstraint");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitConstructorConstraint(node);
    }



    public override void VisitConstructorInitializer(ConstructorInitializerSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ConstructorInitializer");
      var nl = OurLine.NewLine(LineKind.Decl, "ConstructorInitializer");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitConstructorInitializer(node);
    }

    public override void VisitContinueStatement(ContinueStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ContinueStatement"); var nl = OurLine.NewLine(LineKind.Decl, "ContinueStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitContinueStatement(node);
    }


    public override void VisitConversionOperatorMemberCref(ConversionOperatorMemberCrefSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ConversionOperatorMemberCref"); var nl = OurLine.NewLine(LineKind.Decl, "ConversionOperatorMemberCref");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitConversionOperatorMemberCref(node);
    }

    public override void VisitCrefBracketedParameterList(CrefBracketedParameterListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("CrefBracketedParameterList"); var nl = OurLine.NewLine(LineKind.Decl, "CrefBracketedParameterList");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitCrefBracketedParameterList(node);
    }

    public override void VisitCrefParameter(CrefParameterSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("CrefParameter"); var nl = OurLine.NewLine(LineKind.Decl, "CrefParameter");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitCrefParameter(node);
    }

    public override void VisitCrefParameterList(CrefParameterListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("CrefParameterList"); var nl = OurLine.NewLine(LineKind.Decl, "CrefParameterList");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitCrefParameterList(node);
    }

    public override void VisitDeclarationExpression(DeclarationExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("DeclarationExpression"); var nl = OurLine.NewLine(LineKind.Decl, "DeclarationExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitDeclarationExpression(node);
    }

    public override void VisitDeclarationPattern(DeclarationPatternSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("DeclarationPattern"); var nl = OurLine.NewLine(LineKind.Decl, "DeclarationPattern");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitDeclarationPattern(node);
    }

    public override void VisitDefaultExpression(DefaultExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("DefaultExpression"); var nl = OurLine.NewLine(LineKind.Decl, "DefaultExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitDefaultExpression(node);
    }

    public override void VisitDefaultSwitchLabel(DefaultSwitchLabelSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("DefaultSwitchLabel"); var nl = OurLine.NewLine(LineKind.Decl, "DefaultSwitchLabel");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitDefaultSwitchLabel(node);
    }


    public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("DelegateDeclaration"); var nl = OurLine.NewLine(LineKind.Decl, "DelegateDeclaration");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitDelegateDeclaration(node);
    }



    public override void VisitDiscardDesignation(DiscardDesignationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("DiscardDesignation"); var nl = OurLine.NewLine(LineKind.Decl, "DiscardDesignation");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitDiscardDesignation(node);
    }

    public override void VisitDiscardPattern(DiscardPatternSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("DiscardPattern"); var nl = OurLine.NewLine(LineKind.Decl, "DiscardPattern");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitDiscardPattern(node);
    }

    public override void VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("DocumentationCommentTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "DocumentationCommentTrivia");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitDocumentationCommentTrivia(node);
    }


    public override void VisitElementAccessExpression(ElementAccessExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ElementAccessExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitElementAccessExpression(node);
    }

    public override void VisitElementBindingExpression(ElementBindingExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ElementBindingExpression"); var nl = OurLine.NewLine(LineKind.Decl, "ElementBindingExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitElementBindingExpression(node);
    }





    public override void VisitEmptyStatement(EmptyStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("EmptyStatement"); var nl = OurLine.NewLine(LineKind.Decl, "EmptyStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitEmptyStatement(node);
    }




    public override void VisitEqualsValueClause(EqualsValueClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      // Todo("EqualsValueClause");
      var nl = OurLine.NewLine(LineKind.Decl, "EqualsValueClause");
      OurLine.AddEssentialInfo(ref nl, "value:" + node.Value.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitEqualsValueClause(node);
    }



    public override void VisitEventDeclaration(EventDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("EventDeclaration"); var nl = OurLine.NewLine(LineKind.Decl, "Event");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitEventDeclaration(node);
    }

    public override void VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("EventField"); var nl = OurLine.NewLine(LineKind.Decl, "EventField");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitEventFieldDeclaration(node);
    }






    public override void VisitForEachVariableStatement(ForEachVariableStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ForEachVariableStatement"); var nl = OurLine.NewLine(LineKind.Decl, "ForEachVariableStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitForEachVariableStatement(node);
    }

    public override void VisitFromClause(FromClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("FromClause"); var nl = OurLine.NewLine(LineKind.Decl, "FromClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitFromClause(node);
    }

    public override void VisitFunctionPointerType(FunctionPointerTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("FunctionPointerType"); var nl = OurLine.NewLine(LineKind.Decl, "FunctionPointerType");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitFunctionPointerType(node);
    }


    public override void VisitGlobalStatement(GlobalStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("GlobalStatement"); var nl = OurLine.NewLine(LineKind.Decl, "GlobalStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitGlobalStatement(node);
    }

    public override void VisitGotoStatement(GotoStatementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("GotoStatement"); var nl = OurLine.NewLine(LineKind.Decl, "GotoStatement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitGotoStatement(node);
    }

    public override void VisitGroupClause(GroupClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("GroupClause"); var nl = OurLine.NewLine(LineKind.Decl, "GroupClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitGroupClause(node);
    }


    public override void VisitImplicitObjectCreationExpression(ImplicitObjectCreationExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ImplicitObjectCreationExpression"); var nl = OurLine.NewLine(LineKind.Decl, "ImplicitObjectCreationExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitImplicitObjectCreationExpression(node);
    }

    public override void VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "MemberAccessExpression");
      nl.Source = node.ToFullString();
      OurLine.AddEssentialInfo(ref nl, "name:" + node.Name.ToString());
      OurLine.AddEssentialInfo(ref nl, "optoken:" + node.OperatorToken.ToString());
      OurLine.AddEssentialInfo(ref nl, "expression:" + node.Expression.ToString());
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitMemberAccessExpression(node);
    }



    public override void VisitParameterList(ParameterListSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "ParameterList");
      OurLine.AddEssentialInfo(ref nl, "parameters:" + node.Parameters.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitParameterList(node);
    }

    public override void VisitParenthesizedPattern(ParenthesizedPatternSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("ParenthesizedPattern"); var nl = OurLine.NewLine(LineKind.Decl, "ParenthesizedPattern");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitParenthesizedPattern(node);
    }

    public override void VisitPositionalPatternClause(PositionalPatternClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("PositionalPatternClause"); var nl = OurLine.NewLine(LineKind.Decl, "PositionalPatternClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitPositionalPatternClause(node);
    }

    public override void VisitPrimaryConstructorBaseType(PrimaryConstructorBaseTypeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("PrimaryConstructorBaseType"); var nl = OurLine.NewLine(LineKind.Decl, "PrimaryConstructorBaseType");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitPrimaryConstructorBaseType(node);
    }

    public override void VisitPropertyPatternClause(PropertyPatternClauseSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("PropertyPatternClause"); var nl = OurLine.NewLine(LineKind.Decl, "PropertyPatternClause");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitPropertyPatternClause(node);
    }

    public override void VisitRangeExpression(RangeExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("RangeExpression"); var nl = OurLine.NewLine(LineKind.Decl, "RangeExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitRangeExpression(node);
    }

    public override void VisitRecordDeclaration(RecordDeclarationSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("RecordDeclaration"); var nl = OurLine.NewLine(LineKind.Decl, "RecordDeclaration");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitRecordDeclaration(node);
    }

    public override void VisitRecursivePattern(RecursivePatternSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("RecursivePattern"); var nl = OurLine.NewLine(LineKind.Decl, "RecursivePattern");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitRecursivePattern(node);
    }



    public override void VisitRelationalPattern(RelationalPatternSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("RelationalPattern"); var nl = OurLine.NewLine(LineKind.Decl, "RelationalPattern");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitRelationalPattern(node);
    }

    public override void VisitSubpattern(SubpatternSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("Subpattern"); var nl = OurLine.NewLine(LineKind.Decl, "Subpattern");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitSubpattern(node);
    }

    public override void VisitSwitchExpression(SwitchExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("SwitchExpression"); var nl = OurLine.NewLine(LineKind.Decl, "SwitchExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitSwitchExpression(node);
    }

    public override void VisitSwitchExpressionArm(SwitchExpressionArmSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("SwitchExpressionArm"); var nl = OurLine.NewLine(LineKind.Decl, "SwitchExpressionArm");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitSwitchExpressionArm(node);
    }

    public override void VisitTypePattern(TypePatternSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("TypePattern"); var nl = OurLine.NewLine(LineKind.Decl, "TypePattern");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitTypePattern(node);
    }

    public override void VisitUnaryPattern(UnaryPatternSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());

      Todo("UnaryPattern"); var nl = OurLine.NewLine(LineKind.Decl, "UnaryPattern");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitUnaryPattern(node);
    }

    public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      var nl = OurLine.NewLine(LineKind.Decl, "VariableDeclarator");
      OurLine.AddEssentialInfo(ref nl, "name:" + node.Identifier.ToString());
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitVariableDeclarator(node);
    }

    public override void VisitVarPattern(VarPatternSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("VarPattern"); var nl = OurLine.NewLine(LineKind.Decl, "VarPattern");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitVarPattern(node);
    }

    public override void VisitWithExpression(WithExpressionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("WithExpression"); var nl = OurLine.NewLine(LineKind.Decl, "WithExpression");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitWithExpression(node);
    }

    public override void VisitXmlCDataSection(XmlCDataSectionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlCDataSection"); var nl = OurLine.NewLine(LineKind.Decl, "XmlCDataSection");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlCDataSection(node);
    }

    public override void VisitXmlComment(XmlCommentSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlComment"); var nl = OurLine.NewLine(LineKind.Decl, "XmlComment");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlComment(node);
    }

    public override void VisitXmlCrefAttribute(XmlCrefAttributeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlCrefAttribute"); var nl = OurLine.NewLine(LineKind.Decl, "XmlCrefAttribute");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlCrefAttribute(node);
    }

    public override void VisitXmlElement(XmlElementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlElement"); var nl = OurLine.NewLine(LineKind.Decl, "XmlElement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlElement(node);
    }

    public override void VisitXmlElementEndTag(XmlElementEndTagSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlElementEndTag"); var nl = OurLine.NewLine(LineKind.Decl, "XmlElementEndTag");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlElementEndTag(node);
    }

    public override void VisitXmlElementStartTag(XmlElementStartTagSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlElementStartTag"); var nl = OurLine.NewLine(LineKind.Decl, "XmlElementStartTag");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlElementStartTag(node);
    }

    public override void VisitXmlEmptyElement(XmlEmptyElementSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlEmptyElement"); var nl = OurLine.NewLine(LineKind.Decl, "XmlEmptyElement");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlEmptyElement(node);
    }

    public override void VisitXmlName(XmlNameSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlName"); var nl = OurLine.NewLine(LineKind.Decl, "XmlName");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlName(node);
    }

    public override void VisitXmlNameAttribute(XmlNameAttributeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlNameAttribute"); var nl = OurLine.NewLine(LineKind.Decl, "XmlNameAttribute");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlNameAttribute(node);
    }

    public override void VisitXmlPrefix(XmlPrefixSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlPrefix"); var nl = OurLine.NewLine(LineKind.Decl, "XmlPrefix");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlPrefix(node);
    }

    public override void VisitXmlProcessingInstruction(XmlProcessingInstructionSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlProcessingInstruction"); var nl = OurLine.NewLine(LineKind.Decl, "XmlProcessingInstruction");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlProcessingInstruction(node);
    }

    public override void VisitXmlText(XmlTextSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlText"); var nl = OurLine.NewLine(LineKind.Decl, "XmlText");
      nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlText(node);
    }

    public override void VisitXmlTextAttribute(XmlTextAttributeSyntax node)
    {
      if (debug) Console.WriteLine(node.ToFullString());
      Todo("XmlTextAttribute"); var nl = OurLine.NewLine(LineKind.Decl, "XmlTextAttribute");
      nl.Source = node.ToFullString();
      nl.ParentKind = node.Parent.RawKind;
      nl.RawKind = node.RawKind;
      LogCommand(nl);
      base.VisitXmlTextAttribute(node);
    }

  }
}