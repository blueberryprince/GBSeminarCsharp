// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void ArrayAndSummator()
{
    int[] array = new int[20];
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        var random = new Random();
        array[i] = random.Next(-1000,1000);
        Console.Write(array[i]+" ");
        if (array[i] % 2 != 0) sum = sum + array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма нечетных чисел - {sum}");
}
Console.WriteLine("Приветствую! Эта программа создает массив из 20 случайных трехзначных чисел и находит сумму чисел на нечетных позициях");
ArrayAndSummator();