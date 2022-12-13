

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
int[] array = GetArray(12, -9, 9);
PrintArray(array);
System.Console.WriteLine();
/*int[]array1=GetArray(20,0,20);
PrintArray(array1);*/

int positiveSum = 0;
int negativeSum = 0;

foreach (int e1 in array)
{
    if (e1 > 0)
    {
        positiveSum += e1;
    }
    else
    {
        negativeSum = e1;
    }
}
System.Console.WriteLine($"Сумма положительных чисел = {positiveSum}, Сумма отрицательных чисел = {negativeSum}");

