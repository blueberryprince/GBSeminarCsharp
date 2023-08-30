// Напишите программу, которая будет по вводимому пользователем числу выдавать произведение чисел от 1 до N

void Multiplier(int number)
{
    if (number < 1 )
    {
        Console.WriteLine("Вы ввели некорректное число");
        return;
    }
int i = number;
int multi = 1;
while (i>1)
{
    checked // проверка на переполнение типа
    {
        multi *= i; // multi = multi * i
    }
    i--;
}
Console.WriteLine($"Произведение чисел от 1 до {number} = {multi}");
}
Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Multiplier(n);