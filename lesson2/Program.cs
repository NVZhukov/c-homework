/*
void Digits()
{
    Console.WriteLine("Введите целое число");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите еще одно целое число");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x % y == 0) Console.WriteLine($"Число {y} кратно числу {x}");
    else Console.WriteLine($"Остаток деления {y} на {x} равен {y % x}");
}
Digits();
*/

/*
void numbers(int num1)
{
    if (num1 % 7 == 0 && num1 % 23 == 0) Console.WriteLine($"Число {num1} кратно 7 и 23 одновременно");
    else Console.WriteLine($"Число {num1} не кратно 7 и 23");
}

Console.Write("Введите  число: ");
int num1 = int.Parse(Console.ReadLine());

numbers(num1);
Console.WriteLine();
*/

/*
void numbers(int num1, int num2)
{
    if (Math.Pow(num1, 2) == num2) Console.WriteLine($"{num1} является квадратом {num2}");
    else Console.WriteLine($"{num1} не является квадратом {num2}");
}

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

numbers(num1, num2);
Console.WriteLine();
*/

int x = 217549879;
int y = int.Parse(x.ToString().Remove(1, 1));
Console.WriteLine(y);


/*
int x = 2179;
int p = 1;
while (x / p > 9) p *= 10;
int y = x % p;
Console.WriteLine(y);
*/