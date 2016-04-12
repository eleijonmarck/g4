using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replacer.Console
{
    public class ConsolePlaya
    {
        public void AddRule()
        {
            System.Console.WriteLine("Enter a bad bad word..");
            var badword = System.Console.ReadLine();
            System.Console.WriteLine("Now enter a good word to replace it with");
            var goodword = System.Console.ReadLine();
        }

        public void ShowAllRules()
        {
            
        }

        public void SwitcheRoo()
        {
            var switcheroo = System.Console.ReadLine();
            switch (switcheroo)
            {
                case "r":
                    AddRule();
                    SwitcheRoo();
                    break;
                case "s":
                    ShowAllRules();
                    SwitcheRoo();
                    break;
                default:
                    System.Console.WriteLine("loler");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var consoler = new ConsolePlaya();
            System.Console.WriteLine("Hello, and welcome to the replacer");
            System.Console.WriteLine("Please add a rule to the replacer by pressing 'r'");
            consoler.SwitcheRoo();

        }
    }
}
