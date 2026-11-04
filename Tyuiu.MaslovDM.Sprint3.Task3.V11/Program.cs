using System;
using Tyuiu.MaslovDM.Sprint3.Task3.V11.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string str = "sqwreq vqwqq q";

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Заменить буквы q на цифру 7 в строке:                                  *");
            Console.WriteLine("* sqwreq vqwqq q                                                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.ReplaceCharOnNum(str, 'q', '7'));

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}