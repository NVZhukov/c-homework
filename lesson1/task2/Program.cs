try
{
    Console.WriteLine("Введите целое число");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите еще одно целое число");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("И еще одно целое число");
    int z = Convert.ToInt32(Console.ReadLine());
    int max;

    if (x > y && x > z)
    {
        max = x;
    }
    else if (y > x && y > z)
    {
        max = y;
    }
    else
    {
        max = z;
    }
    Console.WriteLine("Максимальное число : " + max);
}
catch
{
    Console.WriteLine("Попробуйте ввести корректные данные");
}