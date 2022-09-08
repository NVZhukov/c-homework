// Console.WriteLine("Введите пятизначное число");  //12345 
// int x = Convert.ToInt32(Console.ReadLine());

// int firstNum = x / 10000;
// int secondNum = (x % 10000) / 1000;
// int fourNum = (x % 100) / 10;
// int fiveNum = x % 10;

// Console.WriteLine(firstNum + " " + secondNum + " " + fourNum + " " + fiveNum);

// if (firstNum == fiveNum || secondNum == fourNum)
// {
//     Console.WriteLine("Это число палиндром!");
// }
// else Console.WriteLine("Это число не палиндром!");
/*
int[] getArr(int k)
{
    int[] array = new int[5];
    array[0] = k / 10000;
    array[1] = (k % 10000) / 1000;
    array[2] = (k % 1000) / 100;
    array[3] = (k % 100) / 10;
    array[4] = k % 10;
    return array;
}

void palindrom(int[] array)
{
    if (array[0] == array[4] || array[1] == array[3])
    {
        Console.WriteLine("Это число палиндром!");
    }
    else Console.WriteLine("Это число не палиндром");
}

void printArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

Console.WriteLine("Введите пятизначное число");  //12345 
int x = Convert.ToInt32(Console.ReadLine());
printArr(getArr(x));
palindrom(getArr(x));
*/
/*
Console.Write("Введите двузначное(или больше) число: ");
int num1 = int.Parse(Console.ReadLine());
int x = num1;
int count = 1;
while (num1 > 10)
{
    num1 /= 10;
    count++;
}

int k = count;

Console.WriteLine(k);
Console.WriteLine(x);


int[] array = new int[k];

for (int i = 0; i < k; i++)
{
    array[i] = (int)((x % Math.Pow(10, (k - i))) / Math.Pow(10, k - 1 - i));
    Console.Write(array[i]);
}
*/
int[] getArr(int num1)
{
    int x = num1;
    int count = 1;
    while (num1 > 10)
    {
        num1 /= 10;
        count++;
    }

    int k = count;

    int[] array = new int[k];

    for (int i = 0; i < k; i++)
    {
        array[i] = (int)((x % Math.Pow(10, (k - i))) / Math.Pow(10, k - 1 - i));
    }
    return array;
}

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

Console.Write("Введите двузначное(или больше) число: ");
int num1 = int.Parse(Console.ReadLine());
palindrom(getArr(num1));