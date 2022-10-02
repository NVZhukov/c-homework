// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

string SeriesNumber(int N)
{
    //if (N == 0) return "\"";
    if (N == 1) return Convert.ToString(N);
    return N + ", " + SeriesNumber(N - 1);
}

try
{
    Console.Write("Введите натуральное число N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"N = {n} -> \"{SeriesNumber(n)}\"");
}
catch
{
    Console.WriteLine("Надо было вводить целое положительное число!");
}