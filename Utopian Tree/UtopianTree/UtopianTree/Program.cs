using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfTests = Convert.ToInt32(Console.ReadLine());
            List<int> heightsToWrite = new List<int>();
            for (int i = 0; i < numberOfTests; i++)
            {
                int numberOfCycles = Convert.ToInt32(Console.ReadLine());
                 heightsToWrite.Add(GetHeightByCycles(numberOfCycles));
            }

            foreach (int height in heightsToWrite)
            {
                Console.WriteLine(height);
            }
        }

        public static int GetHeightByCycles(int numberOfCycles)
        {
            if (numberOfCycles == 0 || numberOfCycles == 1)
            {
                return numberOfCycles + 1;
            }            

            int height = 3;
            for (int x = 3; x <= numberOfCycles; x++)
            {
                if (x % 2 == 0)
                {
                    height++;
                }
                else
                {
                    height = height * 2;
                }
            }

            return height;
        }
    }
}
