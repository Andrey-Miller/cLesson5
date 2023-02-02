// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
    }
    return arr;
}

string PrintArray(double[] arr)
{
    string array = string.Join(", ", arr);
    return array;
}

double MaxMinDiff(double[] arr)
{
    double max=-1000; //на случай, если все числа в массиве меньше 0
    double min=1000; //на случай, если все числа в массиве больше 0
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i] > max) {max = arr[i];}
        if (arr[i] < min) {min = arr[i];}
    }
    //System.Console.WriteLine(max);
    //System.Console.WriteLine(min);
    if (max > 0) {return Math.Round(max-min, 3);}
    else {return Math.Round(min-max, 3);}
}

double[] array = FillArray(5, -10, 10);
System.Console.WriteLine($"Разница между max и min в массиве [{PrintArray(array)}] : {MaxMinDiff(array)}");