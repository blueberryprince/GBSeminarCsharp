// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void ArrayDifference()
{
    double[] array = new double[20];
    double min = 0;
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        var random = new Random();
        var randomDecimal = new Random();
        array[i] = random.Next(-1000,1000) + randomDecimal.NextDouble();
        Console.Write(array[i]+" ");
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным числом в массиве равна {max - min}");
}
ArrayDifference();