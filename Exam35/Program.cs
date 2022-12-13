/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

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

void SearchElements(int[] arr)
{int countElements=0;
    foreach (int element in arr)
    {
        if(element>9&&element<=99){
            countElements++;
        }
    }
    System.Console.WriteLine("Количество элементов , входящих в промежуток от 10 до 99 : "+countElements);
}



int[] array = GetArray(1, 110, 123);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
SearchElements(array);
