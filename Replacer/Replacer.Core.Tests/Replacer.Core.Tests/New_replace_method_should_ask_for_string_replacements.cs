using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

//solution that the interviews will be presented for

// try to test one replacer method
namespace Replacer.Core.Tests
{
    [TestFixture]
    public class New_replace_method_should_ask_for_string_replacements
    {
        [SetUp]
        public void SetUp()
        {
            var Replacer = new Replacer();
        }
    }

    public class Replacer
    {
        string _textToReplace = File.ReadAllText("");
        private string _bad;
        private string _good;

        public void Strings(string bad, string good)
        {
            _bad = bad;
            _good = good;
        }
    }
}
