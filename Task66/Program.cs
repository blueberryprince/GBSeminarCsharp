// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите 2 натуральных числа");
int from = Convert.ToInt32(Console.ReadLine());
int to = Convert.ToInt32(Console.ReadLine());

int checkfrom(int number)
{
    if (number < 1) return checkfrom(number + 1);
    else return number;
}
int newfrom = checkfrom(from);

if (from == to) return;

int SumBetweenTwoNumbers(int from, int to)
{
    if (from < to) 
    return from + SumBetweenTwoNumbers(from+1,to);
    if (from > to)
    return from + SumBetweenTwoNumbers(from-1,to);
    if (from == to)
    return from;
    return 0;
}
int result = SumBetweenTwoNumbers(newfrom,to);
Console.WriteLine(result);
