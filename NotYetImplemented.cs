// VisitCSharp.cs

using System;
using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CsDisplay
{
internal partial class VisitCSharp :  CSharpSyntaxWalker
{
    public Dictionary<string,int> counter = new Dictionary<string,int>();
    public void Todo(string str) {
        Dictionary<string,int> c;
        if (Program.dir) c=Program.counter;
        else c=this.counter;

        // Console.WriteLine("NodeInfo: TODO");
        if (!c.ContainsKey(str)) {
            c[str]=1;
        }
        else {
            c[str]++;
        }
    }

    public override void VisitAccessorDeclaration(AccessorDeclarationSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "AccessorDeclaration");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAccessorDeclaration(node);
    }
    public override void VisitIfDirectiveTrivia(IfDirectiveTriviaSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "IfDirectiveTrivia");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("IfDirectiveTrivia");

        base.VisitIfDirectiveTrivia(node);
    }

    public override void VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ImplicitArrayCreationExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("ImplicitArrayCreationExpression");

        base.VisitImplicitArrayCreationExpression(node);
    }
    public override void VisitImplicitElementAccess(ImplicitElementAccessSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ImplicitElementAccess");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("ImplicitElementAccess");

        base.VisitImplicitElementAccess(node);
    }
    public override void VisitImplicitStackAllocArrayCreationExpression(ImplicitStackAllocArrayCreationExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ImplicitStackAllocArrayCreationExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("ImplicitStackAllocArrayCreationExpression");

        base.VisitImplicitStackAllocArrayCreationExpression(node);
    }
    public override void VisitIncompleteMember(IncompleteMemberSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "IncompleteMember");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("IncompleteMember");

        base.VisitIncompleteMember(node);
    }
    public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "IndexerDeclaration");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("IndexerDeclaration");

        base.VisitIndexerDeclaration(node);
    }
    public override void VisitIndexerMemberCref(IndexerMemberCrefSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "IndexerMemberCref");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("IndexerMemberCref");

        base.VisitIndexerMemberCref(node);
    }
    public override void VisitInitializerExpression(InitializerExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "InitializerExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("InitializerExpression");

        base.VisitInitializerExpression(node);
    }
    public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "InterfaceDeclaration");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("InterfaceDeclaration");

        base.VisitInterfaceDeclaration(node);
    }
    public override void VisitInterpolatedStringExpression(InterpolatedStringExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "InterpolatedStringExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("InterpolatedStringExpression");

        base.VisitInterpolatedStringExpression(node);
    }
    public override void VisitInterpolatedStringText(InterpolatedStringTextSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "InterpolatedStringText");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("InterpolatedStringText");

        base.VisitInterpolatedStringText(node);
    }
    public override void VisitInterpolation(InterpolationSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "Interpolation");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("Interpolation");

        base.VisitInterpolation(node);
    }
    public override void VisitInterpolationAlignmentClause(InterpolationAlignmentClauseSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "InterpolationAlignmentClause");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("InterpolationAlignmentClause");

        base.VisitInterpolationAlignmentClause(node);
    }
    public override void VisitInterpolationFormatClause(InterpolationFormatClauseSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "InterpolationFormatClause");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("InterpolationFormatClause");

        base.VisitInterpolationFormatClause(node);
    }

    public override void VisitIsPatternExpression(IsPatternExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "IsPatternExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("IsPatternExpression");

        base.VisitIsPatternExpression(node);
    }
    public override void VisitJoinClause(JoinClauseSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "JoinClause");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("JoinClause");

        base.VisitJoinClause(node);
    }
    public override void VisitJoinIntoClause(JoinIntoClauseSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "JoinIntoClause");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("JoinIntoClause");

        base.VisitJoinIntoClause(node);
    }
    public override void VisitLabeledStatement(LabeledStatementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "LabeledStatement");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("LabeledStatement");

        base.VisitLabeledStatement(node);
    }
    public override void VisitLetClause(LetClauseSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "LetClause");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("LetClause");

        base.VisitLetClause(node);
    }
    public override void VisitLineDirectiveTrivia(LineDirectiveTriviaSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "LineDirectiveTrivia");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("LineDirectiveTrivia");

        base.VisitLineDirectiveTrivia(node);
    }

    public override void VisitLoadDirectiveTrivia(LoadDirectiveTriviaSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "LoadDirectiveTrivia");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("LoadDirectiveTrivia");

        base.VisitLoadDirectiveTrivia(node);
    }

    public override void VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "LocalFunctionStatement");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("LocalFunctionStatement");

        base.VisitLocalFunctionStatement(node);
    }
    public override void VisitLockStatement(LockStatementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "LockStatement");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("LockStatement");

        base.VisitLockStatement(node);
    }
    public override void VisitMakeRefExpression(MakeRefExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "MakeRefExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("MakeRefExpression");

        base.VisitMakeRefExpression(node);
    }

    public override void VisitMemberBindingExpression(MemberBindingExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "MemberBindingExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("MemberBindingExpression");

        base.VisitMemberBindingExpression(node);
    }
 public override void VisitReturnStatement(ReturnStatementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ReturnStatement");
        nl.Source = node.ToFullString();
        // System.Console.WriteLine(node.Expression.Token.Text)
        LogCommand(nl);
        Todo("ReturnStatement");

        base.VisitReturnStatement(node);
    }
    public override void VisitNameColon(NameColonSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "NameColon");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("NameColon");

        base.VisitNameColon(node);
    }
    public override void VisitNameEquals(NameEqualsSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "NameEquals");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("NameEquals");

        base.VisitNameEquals(node);
    }
    public override void VisitNameMemberCref(NameMemberCrefSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "NameMemberCref");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("NameMemberCref");

        base.VisitNameMemberCref(node);
    }

    public override void VisitNullableType(NullableTypeSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "NullableType");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("NullableType");

        base.VisitNullableType(node);
    }

    public override void VisitOmittedArraySizeExpression(OmittedArraySizeExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "OmittedArraySizeExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("OmittedArraySizeExpression");

        base.VisitOmittedArraySizeExpression(node);
    }
    public override void VisitOmittedTypeArgument(OmittedTypeArgumentSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "OmittedTypeArgument");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("OmittedTypeArgument");

        base.VisitOmittedTypeArgument(node);
    }
    public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "OperatorDeclaration");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("OperatorDeclaration");

        base.VisitOperatorDeclaration(node);
    }
    public override void VisitOperatorMemberCref(OperatorMemberCrefSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "OperatorMemberCref");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("OperatorMemberCref");

        base.VisitOperatorMemberCref(node);
    }
    public override void VisitOrderByClause(OrderByClauseSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "OrderByClause");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("OrderByClause");

        base.VisitOrderByClause(node);
    }
    public override void VisitOrdering(OrderingSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "Ordering");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("Ordering");

        base.VisitOrdering(node);
    }


    public override void VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ParenthesizedExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("ParenthesizedExpression");

        base.VisitParenthesizedExpression(node);
    }
    public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ParenthesizedLambdaExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("ParenthesizedLambdaExpression");

        base.VisitParenthesizedLambdaExpression(node);
    }
    public override void VisitParenthesizedVariableDesignation(ParenthesizedVariableDesignationSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ParenthesizedVariableDesignation");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("ParenthesizedVariableDesignation");

        base.VisitParenthesizedVariableDesignation(node);
    }
    public override void VisitPointerType(PointerTypeSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "PointerType");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("PointerType");

        base.VisitPointerType(node);
    }
    public override void VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "PostfixUnaryExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("PostfixUnaryExpression");

        base.VisitPostfixUnaryExpression(node);
    }
    public override void VisitPragmaChecksumDirectiveTrivia(PragmaChecksumDirectiveTriviaSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "PragmaChecksumDirectiveTrivia");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("PragmaChecksumDirectiveTrivia");

        base.VisitPragmaChecksumDirectiveTrivia(node);
    }
    public override void VisitPragmaWarningDirectiveTrivia(PragmaWarningDirectiveTriviaSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "PragmaWarningDirectiveTrivia");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("PragmaWarningDirectiveTrivia");

        base.VisitPragmaWarningDirectiveTrivia(node);
    }

    public override void VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "PrefixUnaryExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("PrefixUnaryExpression");

        base.VisitPrefixUnaryExpression(node);
    }
    public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "PropertyDeclaration");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("PropertyDeclaration");

        base.VisitPropertyDeclaration(node);
    }
    public override void VisitQualifiedCref(QualifiedCrefSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "QualifiedCref");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("QualifiedCref");

        base.VisitQualifiedCref(node);
    }

    public override void VisitQueryBody(QueryBodySyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "QueryBody");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("QueryBody");

        base.VisitQueryBody(node);
    }
    public override void VisitQueryContinuation(QueryContinuationSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "QueryContinuation");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("QueryContinuation");

        base.VisitQueryContinuation(node);
    }
    public override void VisitQueryExpression(QueryExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "QueryExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("QueryExpression");

        base.VisitQueryExpression(node);
    }
    public override void VisitReferenceDirectiveTrivia(ReferenceDirectiveTriviaSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ReferenceDirectiveTrivia");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("ReferenceDirectiveTrivia");

        base.VisitReferenceDirectiveTrivia(node);
    }
    public override void VisitRefExpression(RefExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "RefExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("RefExpression");

        base.VisitRefExpression(node);
    }
    public override void VisitRefType(RefTypeSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "RefType");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("RefType");

        base.VisitRefType(node);
    }
    public override void VisitRefTypeExpression(RefTypeExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "RefTypeExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("RefTypeExpression");

        base.VisitRefTypeExpression(node);
    }
    public override void VisitRefValueExpression(RefValueExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "RefValueExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("RefValueExpression");

        base.VisitRefValueExpression(node);
    }


    public override void VisitSelectClause(SelectClauseSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "SelectClause");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("SelectClause");

        base.VisitSelectClause(node);
    }
    public override void VisitShebangDirectiveTrivia(ShebangDirectiveTriviaSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ShebangDirectiveTrivia");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("ShebangDirectiveTrivia");

        base.VisitShebangDirectiveTrivia(node);
    }
    public override void VisitSimpleBaseType(SimpleBaseTypeSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "SimpleBaseType");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("SimpleBaseType");

        base.VisitSimpleBaseType(node);
    }
    public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "SimpleLambdaExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("SimpleLambdaExpression");

        base.VisitSimpleLambdaExpression(node);
    }
    public override void VisitSingleVariableDesignation(SingleVariableDesignationSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "SingleVariableDesignation");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("SingleVariableDesignation");

        base.VisitSingleVariableDesignation(node);
    }
    public override void VisitSizeOfExpression(SizeOfExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "SizeOfExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("SizeOfExpression");

        base.VisitSizeOfExpression(node);
    }
    public override void VisitSkippedTokensTrivia(SkippedTokensTriviaSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "SkippedTokensTrivia");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("SkippedTokensTrivia");

        base.VisitSkippedTokensTrivia(node);
    }
    public override void VisitStackAllocArrayCreationExpression(StackAllocArrayCreationExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "StackAllocArrayCreationExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("StackAllocArrayCreationExpression");

        base.VisitStackAllocArrayCreationExpression(node);
    }
    public override void VisitStructDeclaration(StructDeclarationSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "StructDeclaration");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("StructDeclaration");

        base.VisitStructDeclaration(node);
    }
    public override void VisitSwitchSection(SwitchSectionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "SwitchSection");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("SwitchSection");

        base.VisitSwitchSection(node);
    }
    public override void VisitSwitchStatement(SwitchStatementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "SwitchStatement");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("SwitchStatement");

        base.VisitSwitchStatement(node);
    }
    public override void VisitThisExpression(ThisExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ThisExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("ThisExpression");

        base.VisitThisExpression(node);
    }
    public override void VisitThrowExpression(ThrowExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ThrowExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("ThrowExpression");

        base.VisitThrowExpression(node);
    }
    public override void VisitThrowStatement(ThrowStatementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ThrowStatement");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("ThrowStatement");

        base.VisitThrowStatement(node);
    }
    public override void VisitTryStatement(TryStatementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "TryStatement");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("TryStatement");

        base.VisitTryStatement(node);
    }
    public override void VisitTupleElement(TupleElementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "TupleElement");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("TupleElement");

        base.VisitTupleElement(node);
    }
    public override void VisitTupleExpression(TupleExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "TupleExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("TupleExpression");

        base.VisitTupleExpression(node);
    }
    public override void VisitTupleType(TupleTypeSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "TupleType");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("TupleType");

        base.VisitTupleType(node);
    }
    public override void VisitTypeArgumentList(TypeArgumentListSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "TypeArgumentList");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("TypeArgumentList");

        base.VisitTypeArgumentList(node);
    }
    public override void VisitTypeConstraint(TypeConstraintSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "TypeConstraint");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("TypeConstraint");

        base.VisitTypeConstraint(node);
    }
    public override void VisitTypeCref(TypeCrefSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "TypeCref");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("TypeCref");

        base.VisitTypeCref(node);
    }
    public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "TypeOfExpression");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("TypeOfExpression");

        base.VisitTypeOfExpression(node);
    }
    public override void VisitTypeParameter(TypeParameterSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "TypeParameter");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("TypeParameter");

        base.VisitTypeParameter(node);
    }
    public override void VisitTypeParameterConstraintClause(TypeParameterConstraintClauseSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "TypeParameterConstraintClause");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("TypeParameterConstraintClause");

        base.VisitTypeParameterConstraintClause(node);
    }

    public override void VisitUndefDirectiveTrivia(UndefDirectiveTriviaSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "UndefDirectiveTrivia");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("UndefDirectiveTrivia");

        base.VisitUndefDirectiveTrivia(node);
    }
    public override void VisitUnsafeStatement(UnsafeStatementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "UnsafeStatement");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("UnsafeStatement");

        base.VisitUnsafeStatement(node);
    }

    public override void VisitUsingStatement(UsingStatementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "UsingStatement");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("UsingStatement");

        base.VisitUsingStatement(node);
    }

    public override void VisitWarningDirectiveTrivia(WarningDirectiveTriviaSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "WarningDirectiveTrivia");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("WarningDirectiveTrivia");

        base.VisitWarningDirectiveTrivia(node);
    }
    public override void VisitWhenClause(WhenClauseSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "WhenClause");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("WhenClause");

        base.VisitWhenClause(node);
    }
    public override void VisitWhereClause(WhereClauseSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "WhereClause");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("WhereClause");

        base.VisitWhereClause(node);
    }
    public override void VisitWhileStatement(WhileStatementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "WhileStatement");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("WhileStatement");

        base.VisitWhileStatement(node);
    }

    public override void VisitYieldStatement(YieldStatementSyntax node)  {
        if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "YieldStatement");
        nl.Source = node.ToFullString();
        LogCommand(nl);
        Todo("YieldStatement");

        base.VisitYieldStatement(node);
    }

    public override void VisitAccessorList(AccessorListSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "AccessorList");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAccessorList(node);
}

public override void VisitAliasQualifiedName(AliasQualifiedNameSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "AliasQualifiedName");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAliasQualifiedName(node);
}

public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "AnonymousMethodExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAnonymousMethodExpression(node);
}

public override void VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "AnonymousObjectCreationExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAnonymousObjectCreationExpression(node);
}

public override void VisitAnonymousObjectMemberDeclarator(AnonymousObjectMemberDeclaratorSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "AnonymousObjectMemberDeclarator");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAnonymousObjectMemberDeclarator(node);
}

public override void VisitArrayCreationExpression(ArrayCreationExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ArrayCreationExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitArrayCreationExpression(node);
}

public override void VisitArrayRankSpecifier(ArrayRankSpecifierSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ArrayRankSpecifier");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitArrayRankSpecifier(node);
}

public override void VisitArrayType(ArrayTypeSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ArrayType");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitArrayType(node);
}

public override void VisitArrowExpressionClause(ArrowExpressionClauseSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ArrowExpressionClause");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitArrowExpressionClause(node);
}

public override void VisitAttribute(AttributeSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "Attribute");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAttribute(node);
}

public override void VisitAttributeArgument(AttributeArgumentSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "AttributeArgument");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAttributeArgument(node);
}

public override void VisitAttributeArgumentList(AttributeArgumentListSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "AttributeArgumentList");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAttributeArgumentList(node);
}

public override void VisitAttributeList(AttributeListSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "AttributeList");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAttributeList(node);
}

public override void VisitAttributeTargetSpecifier(AttributeTargetSpecifierSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "AttributeTargetSpecifier");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAttributeTargetSpecifier(node);
}

public override void VisitAwaitExpression(AwaitExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "AwaitExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitAwaitExpression(node);
}

public override void VisitBadDirectiveTrivia(BadDirectiveTriviaSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "BadDirectiveTrivia");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitBadDirectiveTrivia(node);
}

public override void VisitBaseExpression(BaseExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "BaseExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitBaseExpression(node);
}

public override void VisitBaseList(BaseListSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "BaseList");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitBaseList(node);
}

public override void VisitBinaryExpression(BinaryExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "BinaryExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitBinaryExpression(node);
}

public override void VisitBinaryPattern(BinaryPatternSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "BinaryPattern");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitBinaryPattern(node);
}

public override void VisitBracketedArgumentList(BracketedArgumentListSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "BracketedArgumentList");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitBracketedArgumentList(node);
}

public override void VisitBracketedParameterList(BracketedParameterListSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "BracketedParameterList");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitBracketedParameterList(node);
}

public override void VisitBreakStatement(BreakStatementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "BreakStatement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitBreakStatement(node);
}

public override void VisitCasePatternSwitchLabel(CasePatternSwitchLabelSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CasePatternSwitchLabel");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCasePatternSwitchLabel(node);
}

public override void VisitCaseSwitchLabel(CaseSwitchLabelSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CaseSwitchLabel");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCaseSwitchLabel(node);
}

public override void VisitCastExpression(CastExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CastExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCastExpression(node);
}

public override void VisitCatchClause(CatchClauseSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CatchClause");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCatchClause(node);
}

public override void VisitCatchDeclaration(CatchDeclarationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CatchDeclaration");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCatchDeclaration(node);
}

public override void VisitCatchFilterClause(CatchFilterClauseSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CatchFilterClause");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCatchFilterClause(node);
}

public override void VisitCheckedExpression(CheckedExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CheckedExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCheckedExpression(node);
}

public override void VisitCheckedStatement(CheckedStatementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CheckedStatement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCheckedStatement(node);
}

public override void VisitClassOrStructConstraint(ClassOrStructConstraintSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ClassOrStructConstraint");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitClassOrStructConstraint(node);
}

public override void VisitCompilationUnit(CompilationUnitSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CompilationUnit");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCompilationUnit(node);
}

public override void VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ConditionalAccessExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitConditionalAccessExpression(node);
}

public override void VisitConditionalExpression(ConditionalExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ConditionalExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitConditionalExpression(node);
}

public override void VisitConstantPattern(ConstantPatternSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ConstantPattern");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitConstantPattern(node);
}

public override void VisitConstructorConstraint(ConstructorConstraintSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ConstructorConstraint");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitConstructorConstraint(node);
}

public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ConstructorDeclaration");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitConstructorDeclaration(node);
}

public override void VisitConstructorInitializer(ConstructorInitializerSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ConstructorInitializer");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitConstructorInitializer(node);
}

public override void VisitContinueStatement(ContinueStatementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ContinueStatement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitContinueStatement(node);
}

public override void VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ConversionOperatorDeclaration");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitConversionOperatorDeclaration(node);
}

public override void VisitConversionOperatorMemberCref(ConversionOperatorMemberCrefSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ConversionOperatorMemberCref");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitConversionOperatorMemberCref(node);
}

public override void VisitCrefBracketedParameterList(CrefBracketedParameterListSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CrefBracketedParameterList");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCrefBracketedParameterList(node);
}

public override void VisitCrefParameter(CrefParameterSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CrefParameter");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCrefParameter(node);
}

public override void VisitCrefParameterList(CrefParameterListSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "CrefParameterList");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitCrefParameterList(node);
}

public override void VisitDeclarationExpression(DeclarationExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "DeclarationExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitDeclarationExpression(node);
}

public override void VisitDeclarationPattern(DeclarationPatternSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "DeclarationPattern");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitDeclarationPattern(node);
}

public override void VisitDefaultExpression(DefaultExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "DefaultExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitDefaultExpression(node);
}

public override void VisitDefaultSwitchLabel(DefaultSwitchLabelSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "DefaultSwitchLabel");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitDefaultSwitchLabel(node);
}

public override void VisitDefineDirectiveTrivia(DefineDirectiveTriviaSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "DefineDirectiveTrivia");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitDefineDirectiveTrivia(node);
}

public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "DelegateDeclaration");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitDelegateDeclaration(node);
}

public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "DestructorDeclaration");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitDestructorDeclaration(node);
}

public override void VisitDiscardDesignation(DiscardDesignationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "DiscardDesignation");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitDiscardDesignation(node);
}

public override void VisitDiscardPattern(DiscardPatternSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "DiscardPattern");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitDiscardPattern(node);
}

public override void VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "DocumentationCommentTrivia");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitDocumentationCommentTrivia(node);
}

public override void VisitDoStatement(DoStatementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "DoStatement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitDoStatement(node);
}

public override void VisitElementAccessExpression(ElementAccessExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ElementAccessExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitElementAccessExpression(node);
}

public override void VisitElementBindingExpression(ElementBindingExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ElementBindingExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitElementBindingExpression(node);
}

public override void VisitElifDirectiveTrivia(ElifDirectiveTriviaSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ElifDirectiveTrivia");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitElifDirectiveTrivia(node);
}

public override void VisitElseClause(ElseClauseSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ElseClause");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitElseClause(node);
}

public override void VisitElseDirectiveTrivia(ElseDirectiveTriviaSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ElseDirectiveTrivia");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitElseDirectiveTrivia(node);
}

public override void VisitEmptyStatement(EmptyStatementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "EmptyStatement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitEmptyStatement(node);
}

public override void VisitEndIfDirectiveTrivia(EndIfDirectiveTriviaSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "EndIfDirectiveTrivia");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitEndIfDirectiveTrivia(node);
}

public override void VisitEndRegionDirectiveTrivia(EndRegionDirectiveTriviaSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "EndRegionDirectiveTrivia");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitEndRegionDirectiveTrivia(node);
}

public override void VisitEnumDeclaration(EnumDeclarationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "EnumDeclaration");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitEnumDeclaration(node);
}

public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "EnumMemberDeclaration");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitEnumMemberDeclaration(node);
}

public override void VisitEqualsValueClause(EqualsValueClauseSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "EqualsValueClause");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitEqualsValueClause(node);
}

public override void VisitErrorDirectiveTrivia(ErrorDirectiveTriviaSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ErrorDirectiveTrivia");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitErrorDirectiveTrivia(node);
}

public override void VisitEventDeclaration(EventDeclarationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "EventDeclaration");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitEventDeclaration(node);
}

public override void VisitEventFieldDeclaration(EventFieldDeclarationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "EventFieldDeclaration");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitEventFieldDeclaration(node);
}

public override void VisitExplicitInterfaceSpecifier(ExplicitInterfaceSpecifierSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ExplicitInterfaceSpecifier");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitExplicitInterfaceSpecifier(node);
}

public override void VisitExternAliasDirective(ExternAliasDirectiveSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ExternAliasDirective");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitExternAliasDirective(node);
}

public override void VisitFieldDeclaration(FieldDeclarationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "FieldDeclaration");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitFieldDeclaration(node);
}

public override void VisitFinallyClause(FinallyClauseSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "FinallyClause");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitFinallyClause(node);
}

public override void VisitFixedStatement(FixedStatementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "FixedStatement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitFixedStatement(node);
}

public override void VisitForEachStatement(ForEachStatementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ForEachStatement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitForEachStatement(node);
}

public override void VisitForEachVariableStatement(ForEachVariableStatementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ForEachVariableStatement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitForEachVariableStatement(node);
}

public override void VisitForStatement(ForStatementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ForStatement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitForStatement(node);
}

public override void VisitFromClause(FromClauseSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "FromClause");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitFromClause(node);
}

public override void VisitFunctionPointerType(FunctionPointerTypeSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "FunctionPointerType");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitFunctionPointerType(node);
}

public override void VisitGenericName(GenericNameSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "GenericName");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitGenericName(node);
}

public override void VisitGlobalStatement(GlobalStatementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "GlobalStatement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitGlobalStatement(node);
}

public override void VisitGotoStatement(GotoStatementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "GotoStatement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitGotoStatement(node);
}

public override void VisitGroupClause(GroupClauseSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "GroupClause");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitGroupClause(node);
}

public override void VisitIdentifierName(IdentifierNameSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "IdentifierName");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitIdentifierName(node);
}

public override void VisitImplicitObjectCreationExpression(ImplicitObjectCreationExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ImplicitObjectCreationExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitImplicitObjectCreationExpression(node);
}

public override void VisitMemberAccessExpression(MemberAccessExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "MemberAccessExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitMemberAccessExpression(node);
}

public override void VisitNullableDirectiveTrivia(NullableDirectiveTriviaSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "NullableDirectiveTrivia");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitNullableDirectiveTrivia(node);
}

public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ObjectCreationExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitObjectCreationExpression(node);
}

public override void VisitParameterList(ParameterListSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ParameterList");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitParameterList(node);
}

public override void VisitParenthesizedPattern(ParenthesizedPatternSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "ParenthesizedPattern");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitParenthesizedPattern(node);
}

public override void VisitPositionalPatternClause(PositionalPatternClauseSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "PositionalPatternClause");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitPositionalPatternClause(node);
}

public override void VisitPrimaryConstructorBaseType(PrimaryConstructorBaseTypeSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "PrimaryConstructorBaseType");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitPrimaryConstructorBaseType(node);
}

public override void VisitPropertyPatternClause(PropertyPatternClauseSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "PropertyPatternClause");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitPropertyPatternClause(node);
}

public override void VisitRangeExpression(RangeExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "RangeExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitRangeExpression(node);
}

public override void VisitRecordDeclaration(RecordDeclarationSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "RecordDeclaration");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitRecordDeclaration(node);
}

public override void VisitRecursivePattern(RecursivePatternSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "RecursivePattern");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitRecursivePattern(node);
}

public override void VisitRegionDirectiveTrivia(RegionDirectiveTriviaSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "RegionDirectiveTrivia");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitRegionDirectiveTrivia(node);
}

public override void VisitRelationalPattern(RelationalPatternSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "RelationalPattern");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitRelationalPattern(node);
}

public override void VisitSubpattern(SubpatternSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "Subpattern");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitSubpattern(node);
}

public override void VisitSwitchExpression(SwitchExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "SwitchExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitSwitchExpression(node);
}

public override void VisitSwitchExpressionArm(SwitchExpressionArmSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "SwitchExpressionArm");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitSwitchExpressionArm(node);
}

public override void VisitTypePattern(TypePatternSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "TypePattern");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitTypePattern(node);
}

public override void VisitUnaryPattern(UnaryPatternSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "UnaryPattern");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitUnaryPattern(node);
}

public override void VisitVariableDeclarator(VariableDeclaratorSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "VariableDeclarator");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitVariableDeclarator(node);
}

public override void VisitVarPattern(VarPatternSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "VarPattern");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitVarPattern(node);
}

public override void VisitWithExpression(WithExpressionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "WithExpression");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitWithExpression(node);
}

public override void VisitXmlCDataSection(XmlCDataSectionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlCDataSection");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlCDataSection(node);
}

public override void VisitXmlComment(XmlCommentSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlComment");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlComment(node);
}

public override void VisitXmlCrefAttribute(XmlCrefAttributeSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlCrefAttribute");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlCrefAttribute(node);
}

public override void VisitXmlElement(XmlElementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlElement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlElement(node);
}

public override void VisitXmlElementEndTag(XmlElementEndTagSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlElementEndTag");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlElementEndTag(node);
}

public override void VisitXmlElementStartTag(XmlElementStartTagSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlElementStartTag");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlElementStartTag(node);
}

public override void VisitXmlEmptyElement(XmlEmptyElementSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlEmptyElement");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlEmptyElement(node);
}

public override void VisitXmlName(XmlNameSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlName");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlName(node);
}

public override void VisitXmlNameAttribute(XmlNameAttributeSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlNameAttribute");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlNameAttribute(node);
}

public override void VisitXmlPrefix(XmlPrefixSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlPrefix");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlPrefix(node);
}

public override void VisitXmlProcessingInstruction(XmlProcessingInstructionSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlProcessingInstruction");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlProcessingInstruction(node);
}

public override void VisitXmlText(XmlTextSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlText");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlText(node);
}

public override void VisitXmlTextAttribute(XmlTextAttributeSyntax node) {
if(debug) Console.WriteLine(node.ToFullString());
        var nl = OurLine.NewLine(LineKind.Decl, "XmlTextAttribute");
nl.Source = node.ToFullString();
        LogCommand(nl);
        base.VisitXmlTextAttribute(node);
}

}
}