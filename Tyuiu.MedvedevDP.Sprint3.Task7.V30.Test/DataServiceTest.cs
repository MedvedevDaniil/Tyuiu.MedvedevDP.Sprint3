using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MedvedevDP.Sprint3.Task7.V30.Lib;

namespace Tyuiu.MedvedevDP.Sprint3.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            double[] valueWaitArray = new double[]
            {
                -15.60,
                -12.35,
                -10.72,
                -8.88,
                -2.16,
                3.25,
                6.64,
                10.30,
                16.17,
                28.10,
                38.41
            };

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}