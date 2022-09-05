//Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого числа.
try
{
    Console.Write("Введите двузначное(или больше) число: ");
    int num1 = int.Parse(Console.ReadLine());
    int x = num1;
    int count = 0;
    while (num1 > 10)
    {
        num1 /= 10;
        count++;
    }

    int k = count;

    if (x > 99)
    {
        int firstDigit = (int)(x / Math.Pow(10, k));
        Console.WriteLine("Первая цифра числа: " + firstDigit);

        int otherDigit = (int)(x % Math.Pow(10, k - 1));
        Console.WriteLine("Остальные цифры числа: " + otherDigit);

        Console.WriteLine($"Нужное число {firstDigit}{otherDigit}");
    }
    else if (x > 9 && x < 100)
    {
        int firstDigit = (int)(x / Math.Pow(10, k));
        Console.WriteLine($"Нужное число {firstDigit}");
    }
    else
    {
        Console.WriteLine("Введите двузначное(или больше) и/или положительное число");
    }
}
catch
{
    Console.WriteLine("Введите корректные данные!");
}