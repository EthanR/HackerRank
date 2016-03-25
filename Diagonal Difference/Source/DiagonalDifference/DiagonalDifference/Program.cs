using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquare = Convert.ToInt32(Console.ReadLine());
            int[,] square = new int[sizeOfSquare, sizeOfSquare];
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int x = 0; x < sizeOfSquare; x++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int y = 0; y < sizeOfSquare; y++)
                {
                    square[x, y] = int.Parse(row[y]);
                    if (x == y)
                    {
                        primaryDiagonal += square[x, y];
                    }

                    if (y == sizeOfSquare - 1 - x)
                    {
                        secondaryDiagonal += square[x, y];
                    }
                }
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
