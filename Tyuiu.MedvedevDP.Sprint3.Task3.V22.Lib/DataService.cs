using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MedvedevDP.Sprint3.Task3.V22.Lib
{
    public class DataService : ISprint3Task3V22
    {
        public int GetMaxCharCount(string value, char item)
        {
            if (string.IsNullOrEmpty(value))
                return 0;

            int currentCount = 0;
            int maxCount = 0;

            foreach (char c in value)
            {
                if (c == item)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 0; 
                }
            }

            return maxCount;
        }
    }
}