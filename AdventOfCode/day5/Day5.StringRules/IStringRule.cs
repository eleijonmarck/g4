using System.Collections.Generic;
namespace Day5.StringRules
{
    public interface IStringRule
    {
        bool Contains_at_least_three_vows(string aString);
        StringFeeling IsNiceOrBad(string Astring);
    }
}