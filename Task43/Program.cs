// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if (x < double.MaxValue && x > double.MinValue && y < double.MaxValue && y > double.MinValue) // Наверняка есть более красивый способ проверки, но я такого не придумал
    {
        Console.WriteLine($"Точка пересечения прямых находится в координатах ({x}, {y})");
    }
    else Console.WriteLine("Прямые не пересекаются");
    return;
}
Console.WriteLine("Приветствую! Эта программа совершенно магическим образом находит точку пересечения двух прямых");
Console.WriteLine("Введите коэффициенты первой прямой y = k1*x + b1");
Console.WriteLine("Коэффициент k1:");
double coefk1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Коэффициент b1:");
double coefb1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициенты второй прямой y = k2*x + b2");
Console.WriteLine("Коэффициент k2:");
double coefk2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Коэффициент b2:");
double coefb2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(coefk1, coefb1, coefk2, coefb2);