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
        public static string phonenumber = "^91([ ])?[6-9]{1}[0-9]{9}$";
        public void Validation(string sample)
        {
            if (Regex.IsMatch(sample, phonenumber))
                Console.WriteLine("Valid phonenumber");
            else
                Console.WriteLine("Invalid phonenumber");
        }
    }
}
