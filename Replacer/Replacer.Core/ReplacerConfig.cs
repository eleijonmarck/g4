using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Replacer.Core
{
    public class ReplacerConfig
    {
        private const string RulesPath = @"c:\temp\Replacer\RulesForStrings.txt";

        public Dictionary<string, string> RuleDictionary
        {
            get
            {
                throw new NotImplementedException();
                //return GetRules().Split(';').Select(x => x.Split(new[] {':'}, 2)).ToDictionary();
                //make into DICTIONARYYY
            }
        }

        public string GetRules()
        {
            return File.ReadAllText(RulesPath);
        } 

        public void AddRule(string bad, string good)
        {
            string RulesText = GetRules();
            string newRules = RulesText + bad + ";" + good;
            File.WriteAllText(RulesPath,newRules);
        }
    }
}