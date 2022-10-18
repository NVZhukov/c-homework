// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillThreeDimencionalArray(int[] mass, int n, int m, int s)
{
    int[,,] matrix = new int[n, m, s];
    for (int a = 0; a < mass.Length; a++)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                for (int k = 0; k < s; k++)
                {
                    matrix[i, j, k] = mass[a];
                    a++;
                }
            }
        }
    }
    return matrix;
}

int[] arr = new int[90];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i + 10;
}

int[] ShuffleArray(int[] array)
{
    Random r = new Random();
    for (int i = array.Length; i > 0; i--)
    {
        int j = r.Next(i);
        int k = array[j];
        array[j] = array[i - 1];
        array[i - 1] = k;
    }
    return array;
}

void PrintArray(int[,,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(2); k++)
            {
                Console.Write($"{mas[j, k, i]} ({j},{k},{i})  ");
            }
            Console.WriteLine();
        }
    }
}

try
{
    int[] array = ShuffleArray(arr);
    PrintArray(FillThreeDimencionalArray(ShuffleArray(arr), 2, 2, 2));
}
catch
{
    Console.WriteLine("Что-то пошло не так((");
}