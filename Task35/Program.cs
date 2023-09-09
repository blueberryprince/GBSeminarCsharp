// Задача 35. Задайте одномерный массив из 123 чисел. Найдите количество элементов массива, значения которых лежат в диапазоне [10,99]

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

int[] arr = CreateRandomArray(123, 0, 500);

void TwoDigitNumberCheck(int[] array)
{
    int twodigitsnumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100) twodigitsnumber++;
    }
    Console.WriteLine($"В массиве находится {twodigitsnumber} двузначных чисел");
}
TwoDigitNumberCheck(arr);