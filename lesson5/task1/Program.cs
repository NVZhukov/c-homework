// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100, 1000);
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
    Console.Write(mas[mas.Length - 1] + "]");
}

int NumbersCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

try
{
    System.Console.WriteLine("Введите размерность массива");
    int k = Convert.ToInt32(Console.ReadLine());
    int[] array = FillArray(k);
    PrintArray(array);
    Console.WriteLine("-> " + NumbersCount(array));
}
catch
{
    Console.WriteLine("Надо было вводить целое положительное число!");
}