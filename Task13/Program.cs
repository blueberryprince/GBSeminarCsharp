// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());
int check = num % 100;
if (check == num) 
{
    Console.WriteLine("Третьей цифры нет");
    Environment.Exit(0);
}
int ThirdDigit = num % 10;
Console.WriteLine($"Третья цифра вашего числа - {ThirdDigit}");