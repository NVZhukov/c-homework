// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int numberPower(int n, int k)
{
    int multi = 1;
    for (int i = 1; i <= n; i++)
    {
        multi = (int)Math.Pow(n, k);
    }
    return multi;
}

try
{
    Console.WriteLine("Введите число которое будем возводить в степень: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите в какую будем возводить степень: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{a} в степени {b} = " + numberPower(a, b));
}
catch
{
    Console.Write("Надо было вводить целые числа!");
}