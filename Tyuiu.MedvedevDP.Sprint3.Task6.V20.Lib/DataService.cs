using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MedvedevDP.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0; 

            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d < 12; d++) 
                {
                    if (x % d == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}