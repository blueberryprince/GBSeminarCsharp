// Задача 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элементы массива
// второй и предпоследний и т.д. Результат записать в одном массиве.

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
int[] arr = CreateRandomArray(13, 1, 9);
PrintArray(arr);
Console.WriteLine();

int[] PairMultiplicationArray(int[] array)
{
    int size = array.Length / 2 + array.Length % 2;
    int[] multiarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        multiarray[i] = array[i] * array[array.Length-1-i];
    }
    if (size%2 == 1) multiarray[size-1] = array[size-1]; // уточнение для массивов с нечетным количеством элементов массива
return multiarray;
}
int[] Multiarray = PairMultiplicationArray(arr);

PrintArray(Multiarray);