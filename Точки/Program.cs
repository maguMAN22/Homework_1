// Филиппов Г.Д.
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)).
//Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);



    Console.Title = ("Точки");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Расстояние между точками с координатами x1,y1 и x2,y2");
    Console.ResetColor();
    Console.WriteLine("Введите x1");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y1");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите x2");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y2");
    double y2 = double.Parse(Console.ReadLine());

    static double Calc(double X1, double Y1, double X2, double Y2)
    {
        double dist = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        return dist;   
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Расстояние между точками " + "{0:F}",Calc(x1,y1,x2,y2));
    Console.ResetColor();
    Console.ReadLine();

