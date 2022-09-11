//Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом.

//Метод превращает любое число в массив его цифр
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

//Метод проверяет является ли число палиндромом
void palindrom(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        if (array[i] == array[array.Length - 1 - i])
        {
            count++;
        }
    }
    if (count == array.Length / 2)
    {
        Console.WriteLine("Это палиндром");
    }
    else Console.WriteLine("Это не палиндром");
}

try
{
    Console.Write("Введите двузначное(или больше) число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    palindrom(getArr(num1));
}
catch
{
    Console.WriteLine("Введите корректные данные!");
}