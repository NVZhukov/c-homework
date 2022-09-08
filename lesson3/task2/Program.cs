//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double distanceTwoDot(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int rezX = (x1 - x2) * (x1 - x2);
    int rezY = (y1 - y2) * (y1 - y2);
    int rezZ = (z1 - z2) * (z1 - z2);

    double rez = Math.Round(Math.Sqrt(rezX + rezY + rezZ), 2);

    return rez;
}

try
{
    Console.WriteLine("Введите координаты первой точки в пространстве: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки в пространстве: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());

    double dist = distanceTwoDot(x1, y1, z1, x2, y2, z2);
    Console.WriteLine(dist);
}
catch
{
    Console.WriteLine("Введите корректные координаты");
}