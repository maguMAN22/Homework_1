//Глеб Филиппов
//Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
//Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива.

int[] array1 = new int[20];
Random randNums = new Random();
for (int i = 0; i < array1.Length; i++)
      {
          array1[i] = randNums.Next(-10000, 10000);
          Console.Write(array1[i] + " ");
      }
Console.WriteLine();
int count = 0;
for (int i = 0; i < array1.Length - 1; i++)
    {
        if (array1[i] % 3 == 0 && array1[i + 1] % 3 == 0)
    {
        count++;
        Console.WriteLine($"Пара чисел: {array1[i]} и {array1[i + 1]}");
    }
 }
  Console.WriteLine("Количество пар: " + count);
  return count;