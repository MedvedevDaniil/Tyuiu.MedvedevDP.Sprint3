using Tyuiu.MedvedevDP.Sprint3.Task1.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        double value = 0.25;
        int startValue = 1;
        int stopValue = 9;
        Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
        Console.ReadKey();
    }
}