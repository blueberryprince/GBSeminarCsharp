// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");

int num = Convert.ToInt32(Console.ReadLine());
int RandomDigit = num % 100;
int SecondDigit = RandomDigit / 10;
Console.WriteLine($"Вторая цифра вашего числа - {SecondDigit}");