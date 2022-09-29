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

int[,] SortedRowMatr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int l = j + 1; l < arr.GetLength(1); l++)
            {
                if (arr[i, j] < arr[i, l])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, l];
                    arr[i, l] = temp;
                }
            }
        }
    }
    return arr;
}

try
{
    System.Console.Write("Введите количество строк n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = FillMas(n,m);
    PrintArray(newArray);
    Console.WriteLine();
    PrintArray(SortedRowMatr(newArray));
}
catch
{
    Console.WriteLine("Надо было вводить целые положительные числа!");
}