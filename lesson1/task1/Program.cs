try
{
    Console.WriteLine("Введите целое число");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите еще одно целое число");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x > y)
    {
        Console.WriteLine("max = " + x);
    }
    else if (y > x)
    {
        Console.WriteLine("max = " + y);
    }
    else
    {
        Console.WriteLine("Числа " + x + " и " + y + " равны");
    }
}
catch
{
    Console.WriteLine("Надо было вводить целые числа!");
}
