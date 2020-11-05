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
}
}