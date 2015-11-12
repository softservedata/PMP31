using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str ="asdfgh1    123.254.1.1 ";
            string pattern = @"\b(25[0-5]|2[0-4][0-9]|[0-9][0-9]|[0-9].)(25[0-5]|2[0-4][0-9]|[0-9][0-9]|[0-9]\.)(25[0-5]|2[0-4][0-9]|[0-9][0-9]|[0-9].)(25[0-5]|2[0-4][0-9]|[0-9][0-9]|[0-9])\b";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(str);
            while (match.Success)
            {
                Console.Write(match.Groups[1].Value);
                Console.Write(match.Groups[2].Value);
                Console.Write(match.Groups[3].Value);
                Console.Write(match.Groups[4].Value);

                
                match = match.NextMatch();
            }
            Console.ReadKey();
        }
    }
}
