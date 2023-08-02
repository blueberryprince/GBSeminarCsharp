Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else 
{
    Console.WriteLine($"Число {a} не вляется квадратом числа {b}");
}