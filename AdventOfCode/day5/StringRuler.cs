using Day5.StringRules;
using System.Collections.Generic;
public class StringRuler
{
    public StringRuler(IEnumerable<IStringRule> stringRules)
    {
    }

    public StringFeeling HowIsStringFeeling()
    {
        var _stringFeeling = new StringFeeling();
        return _stringFeeling;
    }
}