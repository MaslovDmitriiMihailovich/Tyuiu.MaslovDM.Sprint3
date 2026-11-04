using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint3.Task7.V3.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = { 4.34, 4.16, 3.71, 3.27, 2.93, 2.5, 0.71, -47.61, 55.15, 45.17, 14.97 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}