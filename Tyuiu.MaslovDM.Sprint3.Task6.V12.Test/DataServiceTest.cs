using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint3.Task6.V12.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int res = ds.GetSumTheDivisors(9, 18);
            int wait = 221;

            Assert.AreEqual(wait, res);
        }
    }
}