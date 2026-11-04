using System;
using Tyuiu.MaslovDM.Sprint3.Task4.V12.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task4.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* y = x / (x + sin(x)) + 2.5                                             *");
            Console.WriteLine("* x от -5 до 5, при x = 0 цикл прерывается                               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("P = " + ds.Calculate(-5, 5));

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}