//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillMatr(int n, int m)
{
    double[,] mas = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = Math.Round(new Random().NextDouble() * (new Random().Next(-10, 11)), 1);
        }
    }
    return mas;
}

void PrintDoubleArray(double[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write("{0,5}", mas[i, j]);
        }
        Console.WriteLine("]");
    }
}

try
{
    System.Console.Write("Введите количество строк n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов m = ");
    int m = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = FillMatr(n, m);
    PrintDoubleArray(newArray);
}
catch
{
    Console.WriteLine("Надо было вводить целые положительные числа!");
}