// Напишите программу, которая принимает координаты точки X Y на вход и выдает четверть плоскости, в которой находится точка

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
Console.WriteLine("Введите координаты точки X");
int xcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y");
int ycoord = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xcoord, ycoord);
string result = quarter > 0
                        ? $"Указанные координаты соответсвуют {quarter} плоскости"
                        : "Введены некорректные данные";
Console.WriteLine(result);
