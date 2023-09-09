// Задача 32. Напишите программу для замены элементов массива: положительные на отрицательные, а отрицательные на положительные.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] arr = CreateRandomArray(12, -9, 9);
PrintArray(arr);
Console.WriteLine();

int[] InverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) array[i] = -array[i];
        else array[i] = Math.Abs(array[i]);
    }
    return array;
}
InverseArray(arr);
PrintArray(arr);