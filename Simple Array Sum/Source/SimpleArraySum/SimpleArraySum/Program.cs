using System;
using System.Linq;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                string[] stringIntegers = readLine.Split(' ');
                int[] integersToSum = Array.ConvertAll(stringIntegers, int.Parse);
                Console.WriteLine(integersToSum.Sum());
            }
        }
    }
}
