//Филиппов Г.Д.
//Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b)
//Разработать рекурсивный метод, который считает сумму чисел от a до b.
Console.Title = "Рекурсия";
Console.WriteLine("Введите a");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(RecursionNum(A, B));
int OUT = 0;
Console.WriteLine(RecursionNumSumm(A, B, OUT));
Console.ReadLine();
static int RecursionNum(int a, int b)

{
    if (a < b)
    {
     Console.Write(a + " ");
     a++;
     RecursionNum(a, b);
    }
    return b;
}

static int RecursionNumSumm(int a, int b, int Out)

{
    if (a < b)
    {
        Console.Write(a + " ");
        Out = Out + a;
        a++;
        return RecursionNumSumm(a, b, Out);
    }
    return Out;
}
