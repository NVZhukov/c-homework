// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры.
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

int[] SortedArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

int[] OneLine(int[,] array)
{
    int[] mass = new int[array.GetLength(0) * array.GetLength(1)];
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            mass[l] = array[i, j];
            l++;
        }
    }
    return mass;
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

int[,] AgainMatr(int[] array, int k, int l)
{
    int s = 0;
    int[,] matr = new int[k, l];
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < l; j++)
        {
            matr[i, j] = array[s];
            s++;
        }
    }
    return matr;
}

void PrintDoubleArray(int[,] mas)
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

try
{
    Console.Write("Введите количество строк n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов m = ");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = FillMas(n, m);
    PrintDoubleArray(newArray);

    int[] array = SortedArray(OneLine(newArray));
    Console.WriteLine();
    PrintDoubleArray(AgainMatr(array, n, m));
}
catch
{
    Console.WriteLine("Надо было вводить целые положительные числа!");
}