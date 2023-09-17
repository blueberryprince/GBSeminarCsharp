// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите 2 натуральных числа");
int from = Convert.ToInt32(Console.ReadLine());
int to = Convert.ToInt32(Console.ReadLine());

if (from == to)
{
    Console.WriteLine("Сумма чисел в промежутке равна 0");
    return;
}

int checkfrom(int fromnumber)
{
    if (fromnumber < 1) return checkfrom(fromnumber + 1);
    else return fromnumber;
}
int checkto(int tonumber)
{
    if (tonumber < 1) return checkfrom(tonumber + 1);
    else return tonumber;
}
int newfrom = checkfrom(from);
int newto = checkto(to);

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
int result = SumBetweenTwoNumbers(newfrom,newto);
Console.WriteLine(result);
