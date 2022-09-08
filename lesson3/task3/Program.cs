//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string numberPowerThree(int k)
{
    int power = 3;
    string res = $"{k} -> 1";

    for (int i = 2; i <= k; i++)
    {
        res = res + ", " + Math.Pow(i, power);
    }
    return res;
}

try
{
    Console.WriteLine("Введите число до которого будем возводить в куб: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write(numberPowerThree(num));
}
catch
{
    Console.Write("Введите целое число!");
}