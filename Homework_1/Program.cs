// Филиппов Г.Д.
//Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:

Console.Title = ("Анкета");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Анкета");
Console.ResetColor();
Console.WriteLine("Укажите своё имя");
string FName = Console.ReadLine();
Console.WriteLine("Укажите свою фамилию");
string SName = Console.ReadLine();
Console.WriteLine("Укажите свой возраст");
string Age = Console.ReadLine();
Console.WriteLine("Укажите свой рост");
string Height = Console.ReadLine();
Console.WriteLine("Укажите свой вес");
string Weight = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Yellow;
//используя склеивание:
Console.WriteLine("Имя:"+FName+" Фамилия:"+SName+" Возраст:"+Age+" Рост:"+Height+" Вес:"+Weight);
//используя форматированный вывод:
Console.WriteLine("Имя:{0} Фамилия:{1} Возраст:{2} Рост:{3} Вес:{4}",FName,SName,Age,Height,Weight);
//используя вывод со знаком $:
Console.WriteLine($"Имя:{FName} Фамилия:{SName} Возраст:{Age} Рост:{Height} Вес:{Weight}");
Console.ResetColor();
Console.ReadLine();