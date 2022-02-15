//Филиппов Г.Д.
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

Console.Title = ("Сумма чисел");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Подсчёт суммы всех нечетных положительных чисел");
Console.ResetColor();
int n = 0;
int s = 0;
do
{
    Console.WriteLine("Введите натуральное число или 0");
    n = int.Parse(Console.ReadLine());
    if (n > 0 && n % 2 == 1)
    s += n;
}
while (n != 0);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Сумма всех нечетных положительных чисел:{s}");
Console.ResetColor();
Console.ReadLine();
