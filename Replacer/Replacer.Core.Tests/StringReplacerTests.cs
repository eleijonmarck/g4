using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Replacer.Core.Tests
{
    [TestFixture]
    public class StringReplacerTests
    {
        private Replacer _replacer;


        private static string GetTestByName()
        {
            File.ReadAllText(TestFile);
        }

        [SetUp]
        public void Setup()
        {
            _replacer = new Replacer();
            _testDictionary = 
        }

        [Test]
        public void When_a_input_is_
    }

    public class Rules
    {

        public Rules()
        {
            File.ReadAllLines(RulesFile);
        }
    }
    public class Replacer
    {
        public const string TestFile = "./TestStrings.txt";
        public const string InputFile = "./input.txt";
        private readonly string _textInput = File.ReadAllText(InputFile);
        public Replacer()
        {
            
        }

    }
}
