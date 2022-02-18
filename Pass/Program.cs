//Филиппов Г.Д.
//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.

Console.Title = ("Логин и пароль");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Проверка логина и пароля");
Console.ResetColor();
string LOGCheck = "GeekBrains";//задать пароль
string PASCheck = "root";//задать логин



Console.WriteLine(LPcheck(LOGCheck, PASCheck));
Console.ReadLine();
static string LPcheck(string LOGC, string PASC)
{

        int a = 0;
        do
        {
            Console.WriteLine("Введите логин:");
            string log = Console.ReadLine();
            if (log != LOGC)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Пользователь не найден");
            Console.ResetColor();
            }
            else
            ++a;
        }
        while (a == 0);
    int Try = 3;
    do
    {
        Console.WriteLine("Введите пароль:");
        string pas = Console.ReadLine();
        if (pas != PASC)
        {
            Try--;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Вы ввели неверный пароль, осталось попыток - {Try}");
            Console.ResetColor();
        }
        else
        return "Доступ разрешён";          
    }
        while (Try > 0);
    
    return "Доступ запрещён";
    
}
Console.ReadLine();