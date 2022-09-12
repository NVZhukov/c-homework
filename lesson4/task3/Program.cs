//Напишите программу, которая задаёт массив из N элементов и выводит их на экран. N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.

int[] mass(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

try
{
    Console.Write("Введите размер массива: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("[" + String.Join(", ", mass(num1)) + "]");
}
catch
{
    Console.Write("Надо было вводить целые числа!");
}