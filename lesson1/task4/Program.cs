try
{
    Console.WriteLine("Введите целое число");
    int n = Convert.ToInt32(Console.ReadLine());
    int k = 1;
    while (k <= n)
    {
        if (k % 2 == 0)
        {
            Console.Write(k + ", ");
        }
        k++;
    }
}
catch
{
    Console.WriteLine("Надо было вводить целое число!");
}

