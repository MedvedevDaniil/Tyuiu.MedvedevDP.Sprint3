using Tyuiu.MedvedevDP.Sprint3.Task2.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 10;
        Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(startValue, stopValue));
        Console.ReadKey();
    }
}