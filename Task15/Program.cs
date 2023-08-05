// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void HolidayCheck(int num)
{
    bool a = (num > 5) && (num < 8);
    if (a == true)
    {
        Console.WriteLine("День выходной");
    }
    else
    {
        bool b = (num < 1) | (num > 7);
        if (b == true)
        {
            Console.WriteLine("Вы ввели некорректное число");
        }
        else
        Console.WriteLine("День не является выходным");
    }
}
Console.WriteLine("Введите число, обозначающее день недели");
int a = Convert.ToInt32(Console.ReadLine());
HolidayCheck(a);
