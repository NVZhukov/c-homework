//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] UserArray(int k)
{
    int[] array = new int[k];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите целое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PosCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

try
{
    Console.WriteLine("укажите сколько чисел хотите проверить");
    int k = Convert.ToInt32(Console.ReadLine());
    int result = PosCount(UserArray(k));
    Console.Write("Вы ввели " + result + " чисел больше 0");
}
catch
{
    Console.WriteLine("Надо было вводить целое число");
}