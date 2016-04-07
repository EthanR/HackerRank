using System;
using System.Collections.Generic;
using System.Linq;

namespace Pangram
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string potentialPangram = Console.ReadLine();
            Console.WriteLine(GetIsPangram(potentialPangram));
        }

        public static string GetIsPangram(string potentialPangram)
        {
            IEnumerable<char> characters = potentialPangram.ToUpper().Replace(" ", null).Distinct();
            int charactersSize = characters.Count();
            return charactersSize  >= 26 ? "pangram" : "not pangram";
        }
    }
}
