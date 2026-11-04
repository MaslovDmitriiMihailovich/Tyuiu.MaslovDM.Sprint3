using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint3.Task3.V11.Lib;

namespace Tyuiu.MaslovDM.Sprint3.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string res = ds.ReplaceCharOnNum("sqwreq vqwqq q", 'q', '7');
            string wait = "s7wre7 v7w77 7";

            Assert.AreEqual(wait, res);
        }
    }
}