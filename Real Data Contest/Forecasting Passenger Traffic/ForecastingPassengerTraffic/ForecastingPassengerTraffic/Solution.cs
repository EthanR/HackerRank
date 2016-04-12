using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastingPassengerTraffic
{
    class Solution
    {
        static void Main(string[] args)
        {
            int numberOfMonths = Convert.ToInt32(Console.ReadLine());
            List<string> januaryLines = new List<string>();
            List<string> februaryLines = new List<string>();
            List<string> marchLines = new List<string>();
            List<string> aprilLines = new List<string>();
            List<string> mayLines = new List<string>();
            List<string> juneLines = new List<string>();
            List<string> julyLines = new List<string>();
            List<string> augustLines = new List<string>();
            List<string> septemberLines = new List<string>();
            List<string> octoberLines = new List<string>();
            List<string> novemberLines = new List<string>();
            List<string> decemberLines = new List<string>();
            int averageShift = -100000;

            for (int i = 0; i < numberOfMonths; i++)
            {
                switch (i % 12)
                {
                    case 0:
                        januaryLines.Add(Console.ReadLine());
                        break;
                    case 1:
                        februaryLines.Add(Console.ReadLine());
                        break;
                    case 2:
                        marchLines.Add(Console.ReadLine());
                        break;
                    case 3:
                        aprilLines.Add(Console.ReadLine());
                        break;
                    case 4:
                        mayLines.Add(Console.ReadLine());
                        break;
                    case 5:
                        juneLines.Add(Console.ReadLine());
                        break;
                    case 6:
                        julyLines.Add(Console.ReadLine());
                        break;
                    case 7:
                        augustLines.Add(Console.ReadLine());
                        break;
                    case 8:
                        septemberLines.Add(Console.ReadLine());
                        break;
                    case 9:
                        octoberLines.Add(Console.ReadLine());
                        break;
                    case 10:
                        novemberLines.Add(Console.ReadLine());
                        break;
                    case 11:
                        decemberLines.Add(Console.ReadLine());
                        break;
                }
            }

            List<int> januaryPassengers = GetPassengers(januaryLines);
            List<int> februaryPassengers = GetPassengers(februaryLines);
            List<int> marchPassengers = GetPassengers(marchLines);
            List<int> aprilPassengers = GetPassengers(aprilLines);
            List<int> mayPassengers = GetPassengers(mayLines);
            List<int> junePassengers = GetPassengers(juneLines);
            List<int> julyPassengers = GetPassengers(julyLines);
            List<int> augustPassengers = GetPassengers(augustLines);
            List<int> septemberPassengers = GetPassengers(septemberLines);
            List<int> octoberPassengers = GetPassengers(octoberLines);
            List<int> novemberPassengers = GetPassengers(novemberLines);
            List<int> decemberPassengers = GetPassengers(decemberLines);

            Console.WriteLine(Math.Round(januaryPassengers.Average() + averageShift - 100000));
            Console.WriteLine(Math.Round(februaryPassengers.Average() + averageShift + 150000));
            Console.WriteLine(Math.Round(marchPassengers.Average() + averageShift + 150000));
            Console.WriteLine(Math.Round(aprilPassengers.Average() + averageShift - 150000));
            Console.WriteLine(Math.Round(mayPassengers.Average() + averageShift + 150000));
            Console.WriteLine(Math.Round(junePassengers.Average() + averageShift + 150000));
            Console.WriteLine(Math.Round(julyPassengers.Average() + averageShift + 150000));
            Console.WriteLine(Math.Round(augustPassengers.Average() + averageShift - 150000));
            Console.WriteLine(Math.Round(septemberPassengers.Average() + averageShift + 150000));
            Console.WriteLine(Math.Round(octoberPassengers.Average() + averageShift + 150000));
            Console.WriteLine(Math.Round(novemberPassengers.Average() + averageShift + 150000));
            Console.WriteLine(Math.Round(decemberPassengers.Average() + averageShift + 150000));
        }

        public static List<int> GetPassengers(List<string> linesByMonth)
        {
            return linesByMonth.Select(inputLine => Convert.ToInt32(inputLine.Split('\t').First(subString => !subString.StartsWith("MonthNum")))).ToList();
        }
    }
}
