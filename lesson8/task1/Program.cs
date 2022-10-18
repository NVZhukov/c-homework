// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void PrintArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write("{0,3}", mas[i, j]);
        }
        Console.WriteLine("]");
    }
}

int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(1, 10);
        }
    }
    return mas;
}

int[,] SortedMatr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1) - 1; l++)
        {
            for (int j = l + 1; j < array.GetLength(1); j++)
            {
                if (array[i, l] < array[i, j])
                {
                    int temp = array[i, l];
                    array[i, l] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
}

try
{
    System.Console.Write("Введите количество строк n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов m = ");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = FillMas(n, m);
    PrintArray(newArray);
    System.Console.WriteLine();
    PrintArray(SortedMatr(newArray));
}
catch
{
    Console.WriteLine("Надо было вводить целые положительные числа!");
}