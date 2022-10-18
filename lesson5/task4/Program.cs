// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение , возможно придется кое-что для этого дополнительно выполнить.

int[] FillArray(int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(10, 100);
    }
    return mas;
}

void PrintArray(int[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length - 1; i++)
    {
        Console.Write(mas[i] + ", ");
    }
    Console.WriteLine(mas[mas.Length - 1] + "]");
}

int[] MaxMinAverage(int[] array)
{
    int[] diff = new int[5];
    int min = array[0];
    int max = 0;
    int minIndex = 0;
    int maxIndex = 0;
    int average = 0;
    int sumElements = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            diff[0] = min;
            minIndex = i;
            diff[1] = minIndex;
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
            diff[2] = max;
            maxIndex = i;
            diff[3] = maxIndex;
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        sumElements += array[i];
        average = sumElements / array.Length;
    }
    diff[4] = average;
    return diff;
}

void SortedNum(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

int MedianNum(int[] arr)
{
    int median = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr.Length % 2 == 0)
        {
            median = (arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2;
        }
        else
        {
            median = arr[arr.Length / 2];
        }
    }
    return median;
}

try
{
    System.Console.WriteLine("Введите размерность массива");
    int k = Convert.ToInt32(Console.ReadLine());
    int[] array = FillArray(k);
    PrintArray(array);
    int[] mas = MaxMinAverage(array);
    Console.WriteLine($"Минимальное число в массиве = {mas[0]}, его индекс {mas[1]}; максимальное число = {mas[2]}, его индекс {mas[3]}; среднее арифметическое = {mas[4]}");
    Console.Write("Отсортированный массив: ");
    SortedNum(array);
    PrintArray(array);
    Console.WriteLine($"Медиана = {MedianNum(array)}");
}
catch
{
    Console.WriteLine("Надо было вводить целое положительное число!");
}