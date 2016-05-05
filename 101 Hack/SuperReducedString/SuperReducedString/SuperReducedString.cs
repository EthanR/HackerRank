using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class SuperReducedString
    {
        static void Main(string[] args)
        {        
            string input = Console.ReadLine();
            if (input != null && input.Length > 1)
            {
                string reducedString = RemoveDuplicates(input);
                Console.WriteLine(string.IsNullOrEmpty(reducedString) ? "Empty String" : reducedString);
            }
            else
            {
                Console.WriteLine(string.IsNullOrEmpty(input) ? "Empty String" : input);
            }                      
        }

        static string RemoveDuplicates(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input = input.Remove(i, 2);
                    i = -1;
                }
            }

            return input;
        }
    }
}
