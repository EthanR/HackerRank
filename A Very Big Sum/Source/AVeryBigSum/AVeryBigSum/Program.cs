using System;
using System.Linq;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string readLine = Console.ReadLine();
            if (readLine != null)
            {
                string[] integerStrings = readLine.Split(' ');
                long [] integersToSum = Array.ConvertAll(integerStrings, long.Parse);
                Console.WriteLine(integersToSum.Sum());
            }
        }
    }
}
