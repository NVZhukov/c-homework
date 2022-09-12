// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int[] getArr(int num1)
{
    int x = num1;
    int count = 1;
    while (num1 > 10)
    {
        num1 /= 10;
        count++;
    }

    int[] array = new int[count];

    for (int i = 0; i < count; i++)
    {
        array[i] = (int)((x % Math.Pow(10, (count - i))) / Math.Pow(10, count - 1 - i));
    }
    return array;
}

int sumNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

try
{
    Console.Write("Введите двузначное(или больше) целое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Сумма цифр числа {num1} = " + sumNumber(getArr(num1)));
}
catch
{
    Console.WriteLine("Надо было вводить целое число!");
}