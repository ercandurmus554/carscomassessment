using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace wfCarsSiteListen
{
    public static class JSonParser
    {

        //to calculate the car result count but there is no any plain html page.
        //html content comes in a different format it is not proper for regex parse or match.
        public static string ParseToJSon(string htmlContent)
        {
            try
            {
                string retVal = "";
                // Define the Regular Expression, including the "data="
                // but put the latter part (the part we want) in its own group
                Regex regex = new Regex(@"({.*})", RegexOptions.Multiline);
                // Run the regular expression on the input string
                Match match = regex.Match(htmlContent);
                // Now, if we've got a match, grab the first group from it
                if (match.Success)
                {
                    // Now get our JSON string
                    string jsonString = match.Groups[1].Value;
                    // Now do whatever you need to do (e.g. de-serialise the JSON)
                    retVal = jsonString;
                }
                return retVal;

            }
            catch (Exception err)
            {
                return $"Error occored inside ParseToJson: {err.Message}";
            }
        }
    }
}
