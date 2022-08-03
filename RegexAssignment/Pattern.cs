using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexAssignment
{
    public class Patterns
    {
        public static string lastname = "^[A-Z][a-z]{2,}";
        public void Validation(string sample)
        {
            if (Regex.IsMatch(sample, lastname))
                Console.WriteLine("Valid lastname");
            else
                Console.WriteLine("Invalid lastname");
        }
    }
}
