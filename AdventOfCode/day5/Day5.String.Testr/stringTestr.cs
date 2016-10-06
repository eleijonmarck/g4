using NUnit.Framework;
using System.Collections.Generic;
using Day5.StringRules;

namespace Day5.String.Testr
{
    [TestFixture]
    public class StringTestr
    {
        public void StringTestr(IEnumerable<IStringRule> stringRules)
        {
            _rules = new StringRules(stringRules);
        }

        [Test]
        [Testcase("aeiouaeiouaeiou")]
        public void String_contains_at_least_three_vows(string aString)
        {
        }
    }
}