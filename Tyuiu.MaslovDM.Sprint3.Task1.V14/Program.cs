using System;
using Tyuiu.MaslovDM.Sprint3.Task1.V14.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* S = сумма (t^k + 1/(k+1)) * cos(t), k = 1..14                           *");
            Console.WriteLine("* t = 0,7                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("S = " + ds.GetSumSeries(0.7, 1, 14));

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}