// Глеб Филиппов
//Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.

Console.WriteLine("Введите строку 1");
string line1 = Console.ReadLine();
Console.WriteLine("Введите строку 2");
string line2 = Console.ReadLine();
static string AnnG(string Line1, string Line2)
    {
    if (Line1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(Line2.Select(Char.ToUpper).OrderBy(x => x)))
    return "Строка 2 является перестановкой строки 1";
    else
    return "Строка 2 не является перестановкой строки 1";
}

Console.WriteLine(AnnG(line1,line2));
Console.ReadLine();
