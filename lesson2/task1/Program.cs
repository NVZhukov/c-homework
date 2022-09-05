//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void secondDigit()
{
    Console.WriteLine("Введите целое трехзначное число");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 99 && x < 1000)
    {
        int x1 = x % 100;
        int x2 = x1 / 10;
        Console.WriteLine("Вторая цифра введенного числа: " + x2);
    }
    else
    {
        Console.WriteLine("Необходимо трехзначное число!");
    }
}

try
{
    secondDigit();
}
catch
{
    Console.WriteLine("Введите корректные данные!");
}