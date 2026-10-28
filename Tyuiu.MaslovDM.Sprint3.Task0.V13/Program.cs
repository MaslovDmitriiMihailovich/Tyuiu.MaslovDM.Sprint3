using System;
using Tyuiu.MaslovDM.Sprint3.Task0.V13.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* S = сумма (a^k + 1/2) * cos(k), k = 1..20                               *");
            Console.WriteLine("* a = 0,5                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("S = " + ds.GetSumSeries(0.5, 1, 20));

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}