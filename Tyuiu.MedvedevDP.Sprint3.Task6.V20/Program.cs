using Tyuiu.MedvedevDP.Sprint3.Task6.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Task 6 | Вариант 20";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Цикл for + операторы if                                           *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Медведев Даниил Павлович | ИСТНб-24-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();

        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 20;
        int stopValue = 32;

        Console.WriteLine($"Начало отрезка = {startValue}");
        Console.WriteLine($"Конец отрезка = {stopValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.GetSumTheDivisors(startValue, stopValue);

        Console.WriteLine($"Количество делителей (меньших 12) = {result}");

        Console.ReadKey();
    }
}