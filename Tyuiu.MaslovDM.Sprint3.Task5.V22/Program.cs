using System;
using Tyuiu.MaslovDM.Sprint3.Task5.V22.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task5.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* y = сумма(i=1..3) сумма(k=1..12) (x^3 * sin(k)) + 2                    *");
            Console.WriteLine("* x = 2                                                                  *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("y = " + ds.GetSumSumSeries(2, 1, 1, 3, 12));

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}