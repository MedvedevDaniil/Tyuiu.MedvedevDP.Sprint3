using Tyuiu.MedvedevDP.Sprint3.Task0.V19.Lib;
namespace Tyuiu.MedvedevDP.Sprint3.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService dataService = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = dataService.GetSumSeries(startValue, stopValue);
            double wait = 4.399;

            Assert.AreEqual(wait, res);
        }
    }
}