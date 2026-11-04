using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint3.Task4.V12.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(-5, 5);
            double wait = 467.59;

            Assert.AreEqual(wait, res);
        }
    }
}