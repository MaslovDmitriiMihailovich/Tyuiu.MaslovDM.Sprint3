using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MaslovDM.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task2V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            int k = startValue;

            do
            {
                p *= Math.Pow(1.0 / Math.Pow(k, value), -1);
                k++;
            }
            while (k <= stopValue);

            return Math.Round(p, 3);
        }
    }
}