// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNum(int M, int N)
{
    if (M == N) return M;
    return N + SumNum(M, N - 1);
}

try
{
    Console.WriteLine("Считаем сумму натуральных чисел от M до N");
    Console.Write("Введите натуральное число M = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"M = {m}; N = {n} -> {SumNum(m, n)}");
}
catch
{
    Console.WriteLine("Надо было вводить целые положительные числа!");
}