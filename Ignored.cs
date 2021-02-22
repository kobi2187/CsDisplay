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
public override void VisitPragmaChecksumDirectiveTrivia(PragmaChecksumDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("PragmaChecksumDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "PragmaChecksumDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      // Todo("PragmaChecksumDirectiveTrivia");

      base.VisitPragmaChecksumDirectiveTrivia(node);
    }
    public override void VisitUndefDirectiveTrivia(UndefDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("UndefDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "UndefDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      // Todo("UndefDirectiveTrivia");

      base.VisitUndefDirectiveTrivia(node);
    }
      public override void VisitWarningDirectiveTrivia(WarningDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("WarningDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "WarningDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      // Todo("WarningDirectiveTrivia");

      base.VisitWarningDirectiveTrivia(node);
    }
        public override void VisitBadDirectiveTrivia(BadDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("BadDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "BadDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      base.VisitBadDirectiveTrivia(node);
    }
        public override void VisitDefineDirectiveTrivia(DefineDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("DefineDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "DefineDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      base.VisitDefineDirectiveTrivia(node);
    }

        public override void VisitElifDirectiveTrivia(ElifDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("ElifDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "ElifDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      base.VisitElifDirectiveTrivia(node);
    }
   public override void VisitElseDirectiveTrivia(ElseDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("ElseDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "ElseDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      base.VisitElseDirectiveTrivia(node);
    }
    public override void VisitEndIfDirectiveTrivia(EndIfDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("EndIfDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "EndIfDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      base.VisitEndIfDirectiveTrivia(node);
    }


        public override void VisitEndRegionDirectiveTrivia(EndRegionDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("EndRegionDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "EndRegionDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      base.VisitEndRegionDirectiveTrivia(node);
    }

    public override void VisitErrorDirectiveTrivia(ErrorDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("ErrorDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "ErrorDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      base.VisitErrorDirectiveTrivia(node);
    }

    public override void VisitExternAliasDirective(ExternAliasDirectiveSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // if (debug) Console.WriteLine(node.ToString());

      // Todo("ExternAliasDirective");

      // var nl = OurLine.NewLine(LineKind.Decl, "ExternAliasDirective");

      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      base.VisitExternAliasDirective(node);
    }
        public override void VisitNullableDirectiveTrivia(NullableDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("NullableDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "NullableDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      base.VisitNullableDirectiveTrivia(node);
    }


        public override void VisitRegionDirectiveTrivia(RegionDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("RegionDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "RegionDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      base.VisitRegionDirectiveTrivia(node);
    }
        public override void VisitIfDirectiveTrivia(IfDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("IfDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "IfDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      // Todo("IfDirectiveTrivia");

      base.VisitIfDirectiveTrivia(node);
    }

        public override void VisitLineDirectiveTrivia(LineDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("LineDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "LineDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      // Todo("LineDirectiveTrivia");

      base.VisitLineDirectiveTrivia(node);
    }

  public override void VisitLoadDirectiveTrivia(LoadDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("LoadDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "LoadDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      // Todo("LoadDirectiveTrivia");

      base.VisitLoadDirectiveTrivia(node);
    }
    public override void VisitShebangDirectiveTrivia(ShebangDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("ShebangDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "ShebangDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      // Todo("ShebangDirectiveTrivia");

      base.VisitShebangDirectiveTrivia(node);
    }
public override void VisitReferenceDirectiveTrivia(ReferenceDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("ReferenceDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "ReferenceDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      // Todo("ReferenceDirectiveTrivia");

      base.VisitReferenceDirectiveTrivia(node);
    }

    public override void VisitPragmaWarningDirectiveTrivia(PragmaWarningDirectiveTriviaSyntax node)
    {
      // if (debug) Console.WriteLine(node.ToFullString());
      // Todo("PragmaWarningDirectiveTrivia"); var nl = OurLine.NewLine(LineKind.Decl, "PragmaWarningDirectiveTrivia");
      // nl.Source = node.ToFullString();
      // nl.ParentKind = node.Parent.RawKind;
      // nl.RawKind = node.RawKind;
      // LogCommand(nl);
      // Todo("PragmaWarningDirectiveTrivia");

      base.VisitPragmaWarningDirectiveTrivia(node);
    }

  }
}