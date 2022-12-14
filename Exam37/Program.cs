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


void Multiple(int[] arr)    //5,2,6,3,9
{
    if (arr.Length % 2 == 0)
    {
        int[] result = new int[arr.Length / 2];
        for (int i = 0; i < arr.Length / 2; i++)
        {
            result[i] = arr[i] * arr[arr.Length - i - 1];
            System.Console.Write(" " + result[i] + " ");
        }
    }
    else                                                
    {
        int[] result = new int[arr.Length / 2 + 1];     
        for (int i = 0; i < result.Length; i++)
        {
            if (i == arr.Length / 2 )       
            {
                result[i] = arr[i];
                System.Console.Write(result[i]);
                break;
            }
            else
            {
                result[i]=arr[i]*arr[arr.Length-1-i];  
            }
            System.Console.Write($"{result[i]} ");     
        }
    }

}
int[] array = GetArray(1, 8, 4);
PrintArray(array);
System.Console.WriteLine();
Multiple(array);


