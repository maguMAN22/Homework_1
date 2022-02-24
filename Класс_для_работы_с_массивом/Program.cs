//Глеб Филиппов

//а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив
//числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с
//измененными знаками у всех элементов массива (старый массив, остается без изменений), метод Multi,
//умножающий каждый элемент массива на определённое число, свойство MaxCount,
//возвращающее количество максимальных элементов.



public class MyArrays
{
    int[] stArray;
    int Count;
    int Fnum;
    int Step;


    public MyArrays(int count, int fnum, int step)
    {
        Count = count;
        Fnum = fnum;
        Step = step;
        stArray = new int[Count];
        for (int i = 0; i < count; i++)
        {
            stArray[i] = fnum+(step * i);
        }
    }

    public int Sum(int[] arr)
    {
        int b = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            b+=arr[i];
        }
        return b;
    }

    public int[] Inverse(int[] arr)
    {
        int[] newArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = -arr[i];
        }


        return newArr;
    }

    public int[] Multi(int[] arr, int mlt)
    {
        int[] newArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = mlt * arr[i];
        }

        return newArr;
    }

    public int MaxCount(int[] arr)
    {
        int max = arr.Max();
        int b = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == max)
                b += 1;
        }

        return b;
    }

}


