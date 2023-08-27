// Напишите программу, которая на вход принимает координаты двух точек и выдает расстояние между ними в 2D-пространстве

double Distance(int x1, int y1, int x2, int y2)
{
    //int kat1 = Math.Abs(x1 - x2);
  //  int kat2 = Math.Abs(y1 - y2);
    //double gipotenusa = Math.Sqrt(kat1 * kat1 + kat2 * kat2);
    //return gipotenusa;
    return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
}

Console.WriteLine("Введите координаты первой точки в формате (X, Y)");
int xcoord1 = Convert.ToInt32(Console.ReadLine());
int ycoord1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки в формате (X, Y)");
int xcoord2 = Convert.ToInt32(Console.ReadLine());
int ycoord2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xcoord1, ycoord1, xcoord2, ycoord2);
// Console.WriteLine($"Расстояние между точками составляет {Math.Round(distance, 2, MidpointRounding.ToZero)}");
Console.WriteLine($"Расстояние между точками составляет {distance:F3}");