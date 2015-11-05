using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = "<[^>]*>";
            //string pattern = ">[^<]*<";
            string pattern = "(\\w+)(\\.\\w+)*@(\\w+)(.\\w{2,})+";
            //string invest = "ab12cd234aaa11";
            //string invest = "<p><b>Beginning with bold text</b> next, text body, <i>italic text</i> end of text.</p>";
            string invest = "abc._3.a@i.ua";
            Regex regex = new Regex(pattern);
            Console.WriteLine("Is Response to Pattern: "+regex.IsMatch(invest));
            MatchCollection collection = regex.Matches(invest);
            Console.WriteLine("Collection Length = " + collection.Count);
            if ((collection.Count == 1) && (collection[0].Length == invest.Length))
            {
                Console.WriteLine("Full Matches");
            }
            foreach (Match match in collection)
            {
                int len = match.ToString().Length;
                //if (len == 2)
                //{
                //    continue;
                //}
                //Console.WriteLine("\t"+match.ToString().Substring(1, len - 2).Trim());
                Console.WriteLine("\t" + match.ToString().Trim());
            }

            Console.WriteLine("Done");
        }
    }
}
