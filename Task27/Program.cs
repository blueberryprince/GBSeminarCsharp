// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


void NumberSumm(int num)
{
    double sum = 0;
    int i = 1;
    while (num / 10 > 0)
    {
        int digit = num % 10;
        sum = sum + digit;
        num = num / 10;
        i++;
    }
    sum = sum + num % Math.Pow(10,i);
    Console.WriteLine($"Сумма чисел в вашем числе равна {sum}");
}


Console.WriteLine("Приветствую, эта программа считает сумму цифр в произвольно введеном вами числе");
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
NumberSumm(number);
