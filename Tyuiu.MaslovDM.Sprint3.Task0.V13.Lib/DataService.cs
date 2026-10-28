using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MaslovDM.Sprint3.Task0.V13.Lib
{
    public class DataService : ISprint3Task0V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                sum += (Math.Pow(value, k) + 1.0 / 2) * Math.Cos(k);
            }

            return Math.Round(sum, 3);
        }
    }
}