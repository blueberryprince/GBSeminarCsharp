// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int NumberPower(int number, int power)
{
    int i = 2;
    int sum = number;
    if (power == 0) return 1;
    while (i <= power)
    {
        sum = sum * number;
        i++;
    }
    return sum;
}
Console.WriteLine("Приветствую, эта программа возводит заданное вами число в нужную вам степень");
Console.WriteLine("Введите число");
var num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую число нужно возвести");
var pow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumberPower(num,pow));