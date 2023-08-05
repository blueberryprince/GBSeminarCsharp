// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigit(int num)
{
    int RandomDigit = num % 100;
    int SecondDigit = RandomDigit / 10;
    return SecondDigit;
}
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int digit = SecondDigit(num);
Console.WriteLine($"Вторая цифра вашего числа - {digit}");