// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Сторона треугольника не может быть больше суммы двух других сторон.

Console.WriteLine("Эта программа проверяет возможность существования треугольника с длинами сторон, которые вводит пользователь.");

Console.WriteLine("Введите последовательно длины сторон треугольника");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a <= 0 || b <= 0 || c <= 0) 
{
    Console.WriteLine("Сторона треугольника не может быть отрицательной или нулевой");
    return;
}
bool TriangleCheck(int side1, int side2, int side3)
{
    if (side1 <= side2+side3 && side2 <= side1+side3 && side3 <= side1+side2) return true;
    else return false;
}
// а можно было просто сделать вот так:
// return side1 <= side2+side3 && side2 <= side1+side3 && side3 <= side1+side2 
// потому что справа логическое выражение!!!
bool check = TriangleCheck(a,b,c);
if (check == true) Console.WriteLine("Такой треугольник может существовать");
else Console.WriteLine("Такого треугольника не существует");