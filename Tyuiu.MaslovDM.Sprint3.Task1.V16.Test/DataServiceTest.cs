using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint3.Task2.V16.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMultiplySeries()
        {
            DataService ds = new DataService();

            Assert.AreEqual(14400, ds.GetMultiplySeries(2, 1, 5));
        }
    }
}