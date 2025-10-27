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
                -31.46,
                -29.12,
                84.58,   
                6.25,    
                2.97,   
                0.00,    
                12.91,   
                19.75,  
                132.01,  
                -19.73, 
                -16.68
            };

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}