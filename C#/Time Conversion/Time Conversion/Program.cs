using System;
using System.Text.RegularExpressions;

class Solution
{

    static string timeConversion(string s)
    {
        string result = "", pattern = @"^(?<hh>(0\d)|(1[0-2])):(?<mm>[0-5]\d):(?<ss>[0-5]\d)(?<sufix>[A|P]M)$";
        Regex rgx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        MatchCollection matches = rgx.Matches(s);
        foreach (Match match in matches)
        {
            GroupCollection groups = match.Groups;

            int hh = Int32.Parse(groups["hh"].Value);
            
            if (groups["sufix"].Value == "PM" && hh < 12)
            {
                hh = (hh + 12) % 24;
            }
            else if (groups["sufix"].Value == "AM" && hh == 12)
            {
                hh = (hh - 12) % 24;
            }

            result = String.Format("{0:D2}:{1}:{2}", hh, groups["mm"].Value, groups["ss"].Value);
        }
        return result;
    }

    static void Main(string[] args)
    {

        string s = Console.ReadLine();

        string result = timeConversion(s);

        Console.WriteLine(result);
        //Console.ReadLine();
    }
}