//Глеб Филиппов
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.

struct Complex
{
    public double im;
    public double re;
    public Complex Plus(Complex x)
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    public Complex Minus(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }
    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
    public Complex Div(Complex x)
    {
        Complex y;
        y.im = (im * x.re - re * x.im) / (x.re * x.re + x.im * x.im);
        y.re = (re * x.re + im * x.im) / (x.re * x.re + x.im * x.im);
        return y;
    }
    public string ToString()
    {
        if (im < 0) return re +""+ im +"i";
        return re + "+" + im + "i";

    }
}
class ComplexNum
{
    static void Main(string[] args)

    {
        Console.Title = "Комплексные числа";
        while (true)
        { 
        Console.WriteLine("Введите действительное число 1");
        double A1re = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите мнимое число 1");
        double A2im = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите действительное число 2");
        double B1re = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите мнимое число 2");
        double B2im = double.Parse(Console.ReadLine());

        Complex complex1;
        complex1.re = A1re;
        complex1.im = A2im;

        Complex complex2;
        complex2.re = B1re;
        complex2.im = B2im;
        Console.WriteLine("Выберите операцию с мнимым числом(+,-,*,/)");
        string menu = Console.ReadLine();
        Complex result;
            switch (menu)
            {
                case "+":
                    result = complex1.Plus(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case "-":
                    result = complex1.Minus(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case "*":
                    result = complex1.Multi(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case "/":
                    result = complex1.Div(complex2);
                    Console.WriteLine(result.ToString());
                    break;
            }


        }



        


    }
}


