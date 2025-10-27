using Tyuiu.MedvedevDP.Sprint3.Task7.V30.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Task 7 | Вариант 30";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Цикл for + операторы if                                           *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();

        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine($"Начало диапазона = {startValue}");
        Console.WriteLine($"Конец диапазона = {stopValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double[] resultArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("+-----+--------+");
        Console.WriteLine("|  X  |  F(X)  |");
        Console.WriteLine("+-----+--------+");

        for (int i = 0; i < resultArray.Length; i++)
        {
            int x = startValue + i;
            Console.WriteLine($"| {x} | {resultArray[i]} |");
        }

        Console.WriteLine("+-----+--------+");
        Console.ReadKey();
    }
}