/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

int[] GetArray(int min, int max, int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
        System.Console.Write(" " + res[i] + " ");
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

void ProverkaChisla(int[] arr)
{
    System.Console.Write("Введите искомое число: ");
    int chislo = int.Parse(Console.ReadLine()!);
    int a = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == chislo)
        {
            a = chislo;
            //System.Console.WriteLine("Число присутствует в массиве!");
            //break;
        }
        /*else
        {
            System.Console.WriteLine("Числа нет в массиве, ищем дальше...");
        }*/
    }
    if (a == 0)
    {
        System.Console.WriteLine("Числа нет");
    }
    else
    {
        System.Console.WriteLine("Число найдено!");
    }
}
int[] array = GetArray(0, 15, 15);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
ProverkaChisla(array);
