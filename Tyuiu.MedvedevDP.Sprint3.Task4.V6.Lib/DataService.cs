using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.MedvedevDP.Sprint3.Task4.V6.Lib
{
    public class DataService : ISprint3Task4V6
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break; 
                }
                double denominator = Math.Cos(x) - Math.Sin(x);

                double y = x / denominator;
                sum += y;
            }

            return Math.Round(sum, 3);
        }
    }
}