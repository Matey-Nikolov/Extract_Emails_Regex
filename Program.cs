using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Extract_Emails_Regex
{
    class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@"\s(?<email>[A-Z][A-Z]*[.|_|-]?[A-Z0-9]+@[A-Z][A-Z0-9.-]*\.[A-Z]{2,})", RegexOptions.IgnoreCase);
           

            string text = Console.ReadLine();
            //string text = "Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.";

            MatchCollection matchesMail = regex.Matches(text);

            foreach (Match extract in matchesMail)
            {
                Console.WriteLine(extract.Groups["email"].Value);
            }
        }
    }
}
