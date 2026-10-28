using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint3.Task0.V13.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSeries()
        {
            DataService ds = new DataService();

            Assert.AreEqual(0.298, ds.GetSumSeries(0.5, 1, 20));
        }
    }
}