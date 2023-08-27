// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

void Quadrocopter(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i,3}   {Math.Pow(i, 2),5}");
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Quadrocopter(number);
