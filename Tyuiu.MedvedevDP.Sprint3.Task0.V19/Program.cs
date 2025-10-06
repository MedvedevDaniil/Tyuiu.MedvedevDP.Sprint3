using Tyuiu.MedvedevDP.Sprint3.Task0.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 1;
        int stopValue = 10;

        Console.WriteLine($"Старт шага = {startValue}");
        Console.WriteLine($"Конец шага = {stopValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = dataService.GetSumSeries(startValue, stopValue);

        Console.WriteLine($"Сумма ряда = {res}");
        Console.ReadKey();
    }
}