// Глеб Филиппов

//Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов,
//содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) **с использованием регулярных выражений.
Console.Title = "Логин";
Console.WriteLine("Введите логин:");

string login = Console.ReadLine();
byte[] byteN = new byte[255];


int number = 0;

for (int i = 123; i < 255; i++)
{
    byteN[number] = (byte)i;
    number++;
}
for (int i = 0; i < 47; i++)
{
    byteN[number] = (byte)i;
    number++;
}
for (int i = 91; i < 96; i++)
{
    byteN[number] = (byte)i;
    number++;
}
for (int i = 58; i < 64; i++)
{
    byteN[number] = (byte)i;
    number++;
}

char[] charN = System.Text.Encoding.ASCII.GetChars(byteN);

bool check = false;

foreach (var item in charN)
{
    for (int i = 0; i < login.Length; i++)
    {
        if (login[i] == item)
        {
            check = true;
        }
    }
}


if (login.Length >= 2 && login.Length <= 10 && Char.IsDigit((char)login[0]) == false && check == false)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Логин корректен");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Логин не корректен");
    Console.ResetColor();
}

Console.ReadLine();