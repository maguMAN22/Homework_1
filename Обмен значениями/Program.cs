// Филиппов Г.Д.
// Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.
Console.Title = ("Обмен значениями");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Обмен значениями a и b");
Console.ResetColor();
Console.WriteLine("Введите переменную a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите переменную b");
int b = int.Parse(Console.ReadLine());
a = a + b;
b = a - b;
a = a - b;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"a:{a} b:{b}");
Console.ResetColor();
Console.ReadLine();