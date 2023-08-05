// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit(int num)
{
    int check = num % 100;
    int thirddigit = 0;
    if (check == num)
    {
        Console.WriteLine("Третьей цифры нет");
        Environment.Exit(0);
    }
    else 
    {
       thirddigit = num % 10;
    }
    return thirddigit;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int a = ThirdDigit(num);

Console.WriteLine($"Третья цифра вашего числа - {Math.Abs(a)}"); // На всякий случай добавил модуль числа, ибо не понравилось как с отрицательными срабатывает