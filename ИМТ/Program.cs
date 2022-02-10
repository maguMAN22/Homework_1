// Филиппов Г.Д.
//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
Console.Title = ("ИМТ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Расчёт индекса массы тела");
Console.ResetColor();    
Console.WriteLine("Введите массу тела в килограммах");
string Weight = Console.ReadLine();
Console.WriteLine("Введите рост в метрах");
string Height = Console.ReadLine();
double m = double.Parse(Weight);
double h = double.Parse(Height);    
double BMI = m / (h * h);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Ваш ИМТ: "+"{0:F3}",BMI);
Console.ResetColor();
Console.ReadLine();