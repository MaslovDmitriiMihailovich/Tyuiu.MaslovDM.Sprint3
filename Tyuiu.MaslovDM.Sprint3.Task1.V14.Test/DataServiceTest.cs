using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint3.Task1.V14.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSeries()
        {
            DataService ds = new DataService();

            Assert.AreEqual(3.546, ds.GetSumSeries(0.7, 1, 14));
        }
    }
}