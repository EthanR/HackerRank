using System;
using System.Collections.Generic;
using System.Linq;

namespace LanguageDetection
{
    class Solution
    {
        static void Main(String[] args)
        {
            List<string> englishWords = new List<string>
            {
                " the ", " be ", " to " , " of ", " and ", " that ", " have ", " I ", " it ", " for "
            };

            List<string> spanishWords = new List<string>
            {
                " el ", " que ", " y ", " en ", " ser ", " se ", " haber ", " por ", " con ", " su "
            };

            List<string> frenchWords = new List<string>
            {
                " etre ", " avoir ", " je " , " ne ", " pas ", " le ", " vous ", " il ", " et ", "qui"
            };

            List<string> germanWords = new List<string>
            {
                " das ", " ist ", " du" , " ich ", " nicht ", " die ", " und ", "Sie ", " sie ", " der ", " wir "
            };

            string input = string.Empty;
            string nextLine = Console.ReadLine();
            while (!string.IsNullOrEmpty(nextLine))
            {
                input += nextLine + "\n";
                nextLine = Console.ReadLine();
            }

            int englishWordCount = englishWords.Count(word => input.Contains(word));
            int spanishWordCount = spanishWords.Count(word => input.Contains(word));
            int frenchWordCount = frenchWords.Count(word => input.Contains(word));
            int germanWordCount = germanWords.Count(word => input.Contains(word));

            List<int> wordCounts = new List<int> { englishWordCount, spanishWordCount, frenchWordCount, germanWordCount };
            int largestCount = wordCounts.Max();

            if (largestCount == englishWordCount)
            {
                Console.WriteLine("English");
            }
            else if (largestCount == spanishWordCount)
            {
                Console.WriteLine("Spanish");
            }
            else if (largestCount == frenchWordCount)
            {
                Console.WriteLine("French");
            }
            else
            {
                Console.WriteLine("German");
            }
        }
    }
}
