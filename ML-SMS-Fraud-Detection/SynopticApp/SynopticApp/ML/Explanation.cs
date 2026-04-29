using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSFraudDetection.ML;

    public class Explanation
    {
        private static readonly List<string> SpamKeywords = LoadKeywordsFromCsv();

        public static string GenerateExplanation(string message)
        {
            // Defines containsSpamWords list for keyword-based filtering, and producing the explanation. 
            var containsSpamWords = SpamKeywords.Where(keyword => message.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        
            string explanation = "This message is likely spam because it contains words such as: "; // will be + Keywords

            // For each spam word found in the message, it is appended to the "explanation" string, comma seperated for a clear output.
            if (containsSpamWords.Any())
            {
                explanation += string.Join(", ", containsSpamWords);
            }
            else
            {
            // If none match, notification of potential false positive and further safety advice...
                explanation = "This message could be safe, but remember to never share personal information, passwords or transfer money to unknown users.";
            }
            // Returns this result to the Scan Task.
            return explanation;
    }
    


    // This is how the BadWords.csv dataset of spam words is loaded into a keyword list
    private static List<string> LoadKeywordsFromCsv()
        {
            List<string> keywords = new List<string>();


                // <----- Change this to your directory when trying to run the application ----->
                //  YourDirectory--\\SynopticApp\\BadWords.csv 
                using (var reader = new StreamReader("C:\\Users\\Rob\\Desktop\\Download Tests\\RobertHughes21396682\\SynopticApp\\SynopticApp\\BadWords.csv"))
                {
                    // whilst not at the end of the document
                    // and not empty, add it to the keywords list
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            keywords.Add(line.Trim());
                        }
                    }
                }
             //Sends the list to the Explanation.
            return keywords;
        }
}

