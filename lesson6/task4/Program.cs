//Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. 
//Найти минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.

int[,] FillDoubleArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 21);
        }
    }
    return array;
}

void PrintDoubleArray(int[,] mas)
{
    Console.Write("      ");
    for (int i = 1; i <= mas.GetLength(1); i++)
    {
        Console.Write(i + "  ");
    }
    Console.WriteLine();
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        Console.Write(i + 1 + " ");

        Console.Write("[ ");
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write("{0,3}", mas[i, j]);
        }
        Console.WriteLine("]");
    }
}

int[] MinArray(int[,] matr)
{
    int[] array = new int[3];
    int min = matr[0, 0];
    int minRowIndex = 0;
    int minColumnIndex = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                minRowIndex = i;
                minColumnIndex = j;
                array[0] = min;
                array[1] = minRowIndex + 1;             //Выведет числа более понятные для пользователя
                array[2] = minColumnIndex + 1;
            }
        }
    }
    return array;
}

int[] MaxArray(int[,] matr)
{
    int[] array = new int[3];
    int max = 0;
    int maxRowIndex = 0;
    int maxColumnIndex = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > max)
            {
                max = matr[i, j];
                maxRowIndex = i;
                maxColumnIndex = j;
                array[0] = max;
                array[1] = maxRowIndex + 1;
                array[2] = maxColumnIndex + 1;
            }
        }
    }
    return array;
}

try
{
    System.Console.WriteLine("Введите размерность массива");
    System.Console.Write("Количество строк: ");
    int k = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Количество столбцов: ");
    int s = Convert.ToInt32(Console.ReadLine());

    int[,] array = FillDoubleArray(k, s);
    PrintDoubleArray(array);
    int[] masMin = MinArray(array);
    int[] masMax = MaxArray(array);
    Console.WriteLine($"Минимальное число - {masMin[0]}, оно находится в {masMin[1]} строке, {masMin[2]} столбце");
    Console.WriteLine($"Максимальное число - {masMax[0]}, оно находится в {masMax[1]} строке, {masMax[2]} столбце");
}
catch
{
    Console.WriteLine("Надо было вводить целые положительные числа!");
}