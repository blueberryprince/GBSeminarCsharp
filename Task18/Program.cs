// Напишите программу, которая принимает на вход четверть плоскости и выдает диапазон координат

string CoordRange(int q)
{
    if (q == 1) return "x > 0, y > 0";
    if (q == 2) return "x < 0, y > 0";
    if (q == 3) return "x < 0, y < 0";
    if (q == 4) return "x > 0, y < 0";
    return null;
}
Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

string quarter = CoordRange(number);

Console.WriteLine(quarter != null ? $"Диапазон координат {quarter}" : "Ошибка");
