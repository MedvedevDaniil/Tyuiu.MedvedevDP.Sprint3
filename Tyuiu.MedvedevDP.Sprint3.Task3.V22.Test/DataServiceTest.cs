using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MedvedevDP.Sprint3.Task3.V22.Lib;

namespace Tyuiu.MedvedevDP.Sprint3.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMaxCharCount()
        {
            DataService ds = new DataService();

            string str = "tbtbbb dsfbg bbg";
            char chr = 'b';

            int result = ds.GetMaxCharCount(str, chr);

            Assert.AreEqual(3, result); 
        }
    }
}