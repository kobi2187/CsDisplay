using System.Collections.Generic;
// using CsDisplay;

namespace CsDisplay
{
public class Info {
    public List<string> Essentials { get; set; }
    public List<string> Extras { get; set; }
    public override string ToString()
    {
        return "essential: "+  string.Join('#',Essentials) + "; " + "Extra Info: "+ string.Join('#',Extras) ;
    }
    public Info()
    {
        this.Essentials= new List<string>();
        this.Extras= new List<string>();
    }

}

public class OurLine {
    public LineKind Kind { get; set; }
    public string KindStr { get { return this.Kind.ToString();}}
    public string Declaration { get; set; }
    public Info Info{get; set;}
    public string Source {get; set;}
    public override string ToString()
    {
        // return base.ToString();
        string s;
        if (this.Kind != LineKind.EndBlock) {
            s= "kind: " + Kind.ToString() + ", decl name: "+ Declaration ;
            if (this.Info!=null)
                s += ", more info: "+ Info?.ToString();
            return s;
        }
        else return "End of block";
    }
    public OurLine(LineKind kind,string blockName="")
    {
        this.Declaration = blockName;
        this.Kind = kind;
        // this.Info = new Info();
    }

    public static void AddExtraInfo(ref OurLine line, string value) {
        if (line.Info == null) line.Info = new Info();
        line.Info?.Extras?.Add(value);
    }
    public static void AddEssentialInfo(ref OurLine line,string value) {
        if (line.Info == null) line.Info = new Info();
        line.Info?.Essentials?.Add(value);
    }

    public static OurLine NewLine(LineKind kind,string blockName) {
        var l = new OurLine(kind,blockName);
        return l;
    }

}
}