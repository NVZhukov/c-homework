//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

try
{
    Console.WriteLine("Введите цифру, обозначающую день недели");
    int x = Convert.ToInt32(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine("Понедельник, НЕ выходной");
            break;
        case 2:
            Console.WriteLine("Вторник, НЕ выходной");
            break;
        case 3:
            Console.WriteLine("Среда, НЕ выходной");
            break;
        case 4:
            Console.WriteLine("Четверг, НЕ выходной");
            break;
        case 5:
            Console.WriteLine("Пятница, НЕ выходной");
            break;
        case 6:
            Console.WriteLine("Суббота, выходной!Ура");
            break;
        case 7:
            Console.WriteLine("Воскресение, выходной!Ура");
            break;
        default:
            Console.WriteLine("В неделе 7 дней.Введите число от 1 до 7");
            break;
    }
}
catch
{
    Console.WriteLine("Введите корректные данные !");
}