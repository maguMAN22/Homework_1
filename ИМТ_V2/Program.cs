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

if (m < 18.5) 18.5 * h * h - m = dm
        //Здравствуйте, Андрей Александрович. У меня во втором д/з была ошибка в ИМТ_V2,
        //вместо массы работал с самим ИМТ и можно было решить более лаконично (if (imt < 18.5) 18.5 * h * h - m =) 