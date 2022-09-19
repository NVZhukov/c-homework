//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;

void CrossPoint(double x, double y, double z, double v)
{
    if (z != x)                                                                                 //Чтобы найти точку песечения двух прямых необходимо решить систему уравнений
    {                                                                                           // y = k1 * x + b1
        x = (y - v) / (z - x);                                                                  // y = k2 * x + b2;
        y = z * x + v;                                                                          // Для этого из первого вычтем второе:
        Console.WriteLine($"Координаты точки пересечения прямых: ({x};{y})");                   // y - y = k1 * x + b1 - k2 * x - b2;   k2 * x - k1 * x = b1 - b2;  x = (b1 - b2)/(k2 - k1);
    }                                                                                           // y = k2 * x + b2;                     y = k2 * x + b2;            y = k2 * x + b2;
    else
    {
        Console.WriteLine("Прямые параллельны, точек пересечения нет!");
    }
}

try
{
    Console.WriteLine("Введите k1");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b1");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите k2");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b2");
    double b2 = Convert.ToDouble(Console.ReadLine());

    CrossPoint(k1, b1, k2, b2);
}
catch
{
    Console.WriteLine("Надо было вводить целое число");
}