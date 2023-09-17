// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
NaturalNumbers(num);
void NaturalNumbers(int number) 
{
    if (number == 0) return;
    Console.Write($"{number} ");
    NaturalNumbers(number - 1);    
}