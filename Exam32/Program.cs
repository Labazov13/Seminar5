/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

int[] GetArray(int min, int max, int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
        System.Console.Write("\t"+res[i]);
    }
    return res;
}



void reverseArray(int[] arr)
{
    /*foreach (int element in arr)
    {
        if (element < 0)
        {
            arr[element] = element * (-1);
        }
        else
        {
            arr[element] = element * (-1);
        }
    }*/

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            arr[i] = arr[i] * (-1);
        }
        else
        {
            arr[i] = arr[i] * (-1);
        }
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write("\t"+arr[i]);
    }
}

int[] array = GetArray(-9, 9, 10);
System.Console.WriteLine();
reverseArray(array);
System.Console.WriteLine();
PrintArray(array);