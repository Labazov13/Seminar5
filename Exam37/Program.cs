/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] GetArray(int min, int max, int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(" " + arr[i] + " ");
    }
}


void Multiple(int[] arr)    //5,2,6,3
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[(arr.Length/2)] ==arr[i] )
        {
            System.Console.WriteLine(arr[i]);
            break;
        }
        int result = arr[i] * arr[arr.Length - i - 1];
        System.Console.Write(" " + result + " ");
        

    }
}


int[] array = GetArray(1, 8, 5);
PrintArray(array);
System.Console.WriteLine();
Multiple(array);


