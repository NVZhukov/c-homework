// Напишите программу, которая будет находить произведение двух матриц.

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

int[,] FillMas(int n)
{
    int[,] mas = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mas[i, j] = new Random().Next(1, 10);
        }
    }
    return mas;
}

int[,] MultiplyMatrix(int[,] array, int[,] mass)
{
    int[,] matr = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(0); k++)
            {
                matr[i, j] += array[i, k] * mass[k, j];
            }
        }
    }
    return matr;
}

try
{
    System.Console.Write("Введите размер матриц n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = FillMas(n);
    PrintArray(newArray);
    Console.WriteLine();
    int[,] newArray1 = FillMas(n);
    PrintArray(newArray1);
    Console.WriteLine();
    PrintArray(MultiplyMatrix(newArray, newArray1));
}
catch
{
    Console.WriteLine("Надо было вводить целое положительное число!");
}