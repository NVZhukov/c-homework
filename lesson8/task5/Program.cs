// Напишите программу, которая заполнит спирально массив 4 на 4.

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

int[,] SpiralMartix(int size)
{
    int[,] matr = new int[size, size];
    int count = 1;
    int x = 0;
    int y = 0;
    int n = size;
    while (n > 0)
    {
        for (int i = y; i < y + n; i++)
        {
            matr[x, i] = count;
            count++;
        }
        for (int i = x + 1; i < x + n; i++)
        {
            matr[i, y + n - 1] = count;
            count++;
        }
        for (int i = y + n - 2; i >= y; i--)
        {
            matr[x + n - 1, i] = count;
            count++;
        }
        for (int i = x + n - 2; i >= x + 1; i--)
        {
            matr[i, y] = count;
            count++;
        }
        y++;
        x++;
        n -= 2;
    }
    return matr;
}

try
{
    System.Console.Write("Введите размер матрицы n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    PrintArray(SpiralMartix(n));
}
catch
{
    Console.WriteLine("Надо было вводить целое положительное число!");
}