// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>a)
{
    max = b;
}
if (c>a)
{
    max = c;
}
if (b>c)
{
    max = b;
}
Console.WriteLine(max);