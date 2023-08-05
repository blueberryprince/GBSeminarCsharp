// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
do
{
    if (a % 2 == 0)
    {
        Console.Write($" {a}");
    }
    if (a % 2 == 1)
    {
        a = a-1;
        Console.Write($" {a}");
    }
a = a-2;
}
while (a > 0);
