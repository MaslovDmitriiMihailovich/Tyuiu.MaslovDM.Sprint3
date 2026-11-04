using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint3.Task5.V22.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            double res = ds.GetSumSumSeries(2, 1, 1, 3, 12);
            double wait = 68.991;

            Assert.AreEqual(wait, res);
        }
    }
}