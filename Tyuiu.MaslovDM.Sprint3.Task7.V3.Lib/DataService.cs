using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MaslovDM.Sprint3.Task7.V3.Lib
{
    public class DataService : ISprint3Task7V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) - 3 + x;

                if (denominator == 0)
                {
                    valueArray[index] = 0;
                }
                else
                {
                    valueArray[index] = Math.Round((3 * x - 1.5) / denominator + 2, 2);
                }

                index++;
            }

            return valueArray;
        }
    }
}