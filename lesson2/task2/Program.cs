try
{
    Console.WriteLine("Введите целое число");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x > 99)
    {
        int x2 = x;
        while (x2 >= 1000)
        {
            x2 /= 10;
        }
        int x1 = x2 % 10;
        Console.WriteLine($"У числа {x} третья цифра - {x1}");
    }
    else
    {
        Console.WriteLine($"У числа {x} нет третьей цифры");
    }
}
catch
{
    Console.WriteLine("Введите корректные данные!");
}