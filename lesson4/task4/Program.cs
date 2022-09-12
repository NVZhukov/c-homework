// Напишите программу, которая принимает на вход число (целое или вещественное) и выдаёт количество цифр в числе.

int numberDigits(decimal num)
{
    int count = 1;

    if (num % 1 == 0)
    {
        while (num > 10)
        {
            num /= 10;
            count++;
        }
    }
    else
    {
        while (num % 1 > 0)
        {
            num *= 10;
        }
        while (num > 10)
        {
            num /= 10;
            count++;
        }
    }
    return count;
}

try
{
    Console.Write("Введите целое или вещественное число ");
    decimal a = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine(numberDigits(a));
}
catch
{
    Console.Write("Введите корректные данные");
}
