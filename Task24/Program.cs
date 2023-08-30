// Напишите программу, которая будет по вводимому пользователем числу выдавать сумму чисел от 1 до N

void Summator(int number)
{
int i = number;
int summ = 0;
while (i>=1)
{
    checked // проверка на переполнение типа
    {
        summ += i; // sum = sum + i
    }
    i--;
}
Console.WriteLine(summ);
}
Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
Summator(n);
