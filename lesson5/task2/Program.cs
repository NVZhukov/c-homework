// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 20);
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

int SumUnevenCell(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        result += arr[i];
    }
    return result;
}

try
{
    System.Console.Write("Введите размерность массива: ");
    int k = Convert.ToInt32(Console.ReadLine());
    int[] array = FillArray(k);
    PrintArray(array);
    Console.WriteLine("Сумма элементов с нечетными индексами = " + SumUnevenCell(array));
}
catch
{
    Console.WriteLine("Надо было вводить целое положительное число!");
}