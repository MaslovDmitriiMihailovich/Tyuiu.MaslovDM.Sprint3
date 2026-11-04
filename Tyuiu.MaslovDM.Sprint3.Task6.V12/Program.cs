using System;
using Tyuiu.MaslovDM.Sprint3.Task6.V12.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Найти сумму всех делителей целых чисел отрезка [9, 18]                 *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(9, 18));

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}