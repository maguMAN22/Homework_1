// Филиппов Г.Д.
// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организовать в центре экрана.
//в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).
static void M()
{
    Console.Title = ("Имя,фамилия и город");
    Console.WriteLine("Выберите а, б или в");
    string menu = Console.ReadLine();
    switch (menu)
    {
        case "а":
            A();
            break;
        case "б":
            B();
            break;
        case "в":
            C();
            break;

    }
}
while(true)
{
    M();
}

static void A()
{
   
    Console.WriteLine("Укажите своё имя");
    string FName = Console.ReadLine();
    Console.WriteLine("Укажите свою фамилию");
    string SName = Console.ReadLine();
    Console.WriteLine("Укажите свой город проживания");
    string City = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Имя: {FName} Фамилия: {SName} Город: {City}");
    Console.ResetColor();
    Console.WriteLine();
}
static void B()
{
   
    Console.WriteLine("Укажите своё имя");
    string FName = Console.ReadLine();
    Console.WriteLine("Укажите свою фамилию");
    string SName = Console.ReadLine();
    Console.WriteLine("Укажите свой город проживания");
    string City = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
    Console.WriteLine($"Имя:{FName} Фамилия:{SName} Город:{City}");
    Console.ResetColor();
    Console.WriteLine();
}
static void C()
{
   
    Console.WriteLine("Укажите своё имя");
    string FName = Console.ReadLine();
    Console.WriteLine("Укажите свою фамилию");
    string SName = Console.ReadLine();
    Console.WriteLine("Укажите свой город проживания");
    string City = Console.ReadLine();
    static void Print(string F, string S, string C)
    {
        Console.WriteLine($"Имя:{F} Фамилия:{S} Город:{C}");
        Console.ReadKey();
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Print(FName, SName, City);
    Console.ResetColor();

}