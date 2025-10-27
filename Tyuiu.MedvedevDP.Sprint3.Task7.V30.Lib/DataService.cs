using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MedvedevDP.Sprint3.Task7.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;
            double y;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((5 * x + 2.5) / (Math.Sin(x) + 2)) + 2*x + 2;
                }

                y = Math.Round(y, 2);

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}