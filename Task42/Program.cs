// Задача 42. Напишите программу, которая преобразует десятичное число в двоичное.

Console.WriteLine("Эта программа преобразует десятичные числа в двоичные");
Console.WriteLine("Введите десятичное число");
int number = Convert.ToInt32(Console.ReadLine());

/* string Transformer(int num)
{
string binary = string.Empty;
    while (num > 0)
    {
        binary = num % 2 + binary;
        num = num / 2;
    }
return binary;
}
string binarynumber = Transformer(number);
Console.WriteLine($"{number} в двоичном виде равно {binarynumber}"); */

int DtB(int num)
{
    int binary = 0;
    int mult = 1;
    while (number != 0)
    {
        binary = binary + mult*(number%2);
        number = number/2;
        mult = mult * 10; // Кидает на разряды вперед. Крутая идея.
    }
    return binary;
}
int binar = DtB(number);
Console.WriteLine(binar);