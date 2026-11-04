using System;
using Tyuiu.MaslovDM.Sprint3.Task7.V3.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* F(x) = (3x - 1.5) / (sin(x) - 3 + x) + 2                               *");
            Console.WriteLine("* Диапазон: [-5; 5], шаг 1                                               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            double[] result = ds.GetMassFunction(startValue, stopValue);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("F(" + (startValue + i) + ") = " + result[i]);
            }

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}