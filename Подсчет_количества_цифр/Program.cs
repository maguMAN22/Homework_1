//Филиппов Г.Д.
//Написать метод подсчета количества цифр числа.

Console.Title = ("Подсчет количества цифр числа");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Подсчет количества цифр числа");
Console.ResetColor();
Console.WriteLine("Введите натуральное число");
int d = int.Parse(Console.ReadLine());
static int CountDig( int D )
{
    int DC = (int)Math.Log10(D) + 1;
    return DC;
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Количество цифр числа: " + CountDig(d));
Console.ResetColor();
Console.ReadLine();
