// Напишите программу, которая принимает на вход число и выдает количество цифр в этом числе

void Digits(int num)
{
    int i = 0;
    if (num == 0)
    {
        i = 1;
        Console.WriteLine(i);
        return;
    }
    while (Math.Abs(num) > 0)
    {
        i+=1;
        num = Math.Abs(num) / 10;
    }
    Console.WriteLine(i);
}


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Digits(n);
