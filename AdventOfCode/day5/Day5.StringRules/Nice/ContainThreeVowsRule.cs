using System.Collections.Generic;
public class ContainThreeVowsRule : INiceRule
{
    private List<string> _vows = new List<string>() 
    {
        "a",
        "e",
        "i",
        "o",
        "u"
    };
    public bool IsNice(string Astring)
    {
        return Astring.Contains("a","e",1;
    }
}