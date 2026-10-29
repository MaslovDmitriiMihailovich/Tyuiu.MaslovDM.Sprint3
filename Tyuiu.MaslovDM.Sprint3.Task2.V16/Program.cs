using System;
using Tyuiu.MaslovDM.Sprint3.Task2.V16.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task2.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* P = произведение (1 / k^n)^(-1), k = 1..5                               *");
            Console.WriteLine("* n = 2                                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("P = " + ds.GetMultiplySeries(2, 1, 5));

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}