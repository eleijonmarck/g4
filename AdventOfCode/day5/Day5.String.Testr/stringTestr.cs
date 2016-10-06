using NUnit.Framework;
using System.Collections.Generic;
using Day5.StringRules;

namespace Day5.String.Testr
{
    [TestFixture]
    public class StringTestr
    {
        private StringRuler _stringruler;
        private StringFeeling _stringFeeling;

        [SetUp]
        public void SetUp(IEnumerable<IStringRule> stringRules)
        {
            _stringruler = new StringRuler(stringRules);
            _stringFeeling = new StringFeeling();
        }

        [Test]
        [TestCase("aeiouaeiouaeiou")]
        public void String_contains_at_least_three_vows(string aString)
        {
            Assert.Equals(_stringFeeling.Nice,_stringruler.howIsStringFeeling(aString));
        }
    }
}