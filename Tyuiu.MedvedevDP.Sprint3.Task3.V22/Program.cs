using Tyuiu.MedvedevDP.Sprint3.Task3.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();

        string value = "tbtbbb dsfbg bbg";
        char chr = 'b';

        Console.WriteLine($"Исходная строка = {value}");
        Console.WriteLine($"Искомый символ = {chr}");

        int result = ds.GetMaxCharCount(value, chr);

        Console.WriteLine($"Максимальное количество подряд идущих '{chr}' = {result}");

        Console.ReadKey();
    }
}