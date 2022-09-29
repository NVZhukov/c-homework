// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int RowWithMinSum(int[,] matr)
{
    int sum = 0;
    int row = 0;
    int[] mas = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
            mas[i] = sum;
        }
        sum = 0;
    }
    for (int l = 1; l < mas.Length; l++)
    {
        int min = mas[0];
        if (min > mas[l])
        {
            min = mas[l];
            row = l;
        }
    }
    return row;
}

try
{
    System.Console.Write("Введите количество строк n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = FillMas(n, m);
    PrintArray(newArray);
    Console.Write($"Минимальная сумма элементов в {RowWithMinSum(newArray)} строке");
}
catch
{
    Console.WriteLine("Надо было вводить целые положительные числа!");
}