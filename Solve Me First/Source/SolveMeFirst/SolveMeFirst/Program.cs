using System;

namespace SolveMeFirst
{
    class Program
    {        
        static void Main(String[] args)
        {
            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());
            int sum = SolveMeFirst(firstValue, secondValue);
            Console.WriteLine(sum);
        }
    
        static int SolveMeFirst(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
