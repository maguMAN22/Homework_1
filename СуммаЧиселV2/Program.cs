// Глеб Филиппов
//С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.



Console.Title = ("Сумма чисел");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Подсчёт суммы всех нечетных положительных чисел");
Console.ResetColor();
int n;
int s = 0;
bool flag;
do
{
    do {
        Console.WriteLine("Введите целое число или 0");
        flag = int.TryParse(Console.ReadLine(), out n);
        if (flag == false) Console.WriteLine("Введите ЦЕЛОЕ число");


        if (n > 0 && n % 2 == 1)
            s += n;

    }
    while (flag == false);
}
while (n != 0);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Сумма всех нечетных положительных чисел:{s}");
Console.ResetColor();
Console.ReadLine();