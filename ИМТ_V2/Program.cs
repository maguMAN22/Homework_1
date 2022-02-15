//Филиппов Г.Д.
//а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса

Console.Title = ("ИМТ v2");
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
Console.WriteLine("Ваш ИМТ: " + "{0:F3}", BMI);
Console.WriteLine(YW(BMI)); //похудеть, набрать вес или всё в норме.
Console.WriteLine(LosGetW(BMI));//на сколько кг похудеть или сколько кг набрать для нормализации веса
Console.ReadLine();
static string YW(double bmi)
{
    string MaW = "У вас избыточный вес";
    string MiW = "У вас нехватка веса";
    string NormW = "У вас нормальный вес";
    string YourW = bmi < 18.5 ? MiW : bmi > 25 ? MaW : NormW;
    return YourW;
}

static string LosGetW(double bmi)
{
    if (bmi < 18.5)
    {
        do
        {
            bmi = (bmi + 0.1);
        }
        while (bmi >= 18.5);
        return $"Вам нужно набрать {bmi:F3}кг.";
    }
    else if (bmi > 25)
    {
        do
        {
            bmi = (bmi - 0.1);
        }
        while (bmi <= 25);
        return $"Вам нужно похудеть на {bmi:F3}кг.";
    }
    else
        return "Вам не нужно набирать/снижать свой вес";
}