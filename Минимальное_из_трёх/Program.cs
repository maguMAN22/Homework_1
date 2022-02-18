//Филиппов Г.Д.
//Написать метод, возвращающий минимальное из трёх чисел.
Console.Title = ("Минимальное из трёх");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Возвращение минимального из трёх чисел");
Console.ResetColor();

    Console.WriteLine("Введите первое число");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    double c = double.Parse(Console.ReadLine());

    static double MINnum3(double A, double B, double C)
    {
        double min = A < B & A < C ? A : B < C ? B : C;
        return min;
    }

Console.ForegroundColor= ConsoleColor.Yellow;
    Console.WriteLine("Минимальное число: "+MINnum3(a, b, c));
    Console.ResetColor();
Console.ReadLine();
 


