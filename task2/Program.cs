// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int OddIndexSum(int[] array)
{
    int sum = 0;
    for (int i=1; i<array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

string PrintArray(int[] arr)
{
    string array = string.Join(", ", arr);
    return array;
}

int[] array = FillArray(10, -10, 10);
System.Console.WriteLine($"Сумма элементов с нечётными индексами в массиве [{PrintArray(array)}] : {OddIndexSum(array)}"); 