// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void ArrayCreator()
{
    int[] array = new int[20];
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        var random = new Random();
        array[i] = random.Next(100,1000);
        Console.Write(array[i]+" ");
        if (array[i] % 2 == 0) sum++;
    }
    Console.WriteLine();
    Console.WriteLine($"Число четных чисел в массиве - {sum}");
}
Console.WriteLine("Приветствую! Эта программа создает массив из 20 случайных трехзначных чисел и находит число четных чисел в нем");
ArrayCreator();