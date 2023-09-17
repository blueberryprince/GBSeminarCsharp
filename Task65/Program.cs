// Задача 65. Задайте значения M и N. 
// Напишите программу, которая будет выводить все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите 2 натуральных числа");
int from = Convert.ToInt32(Console.ReadLine());
int to = Convert.ToInt32(Console.ReadLine());

if (from < 1 || to < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

void TwoNaturalNumbers(int from, int to)
{
    if (from < to)
    {
        Console.Write($"{from} ");
        TwoNaturalNumbers(from + 1, to);
    }
    if (from > to)
    {
        Console.Write($"{from} ");
        TwoNaturalNumbers(from - 1, to);
    }
    if (from == to)
    {
        Console.Write($"{from}");
    }
}
TwoNaturalNumbers(from,to);
