// Задача 31. Задайте массив и 12 элементов, заполненный случайными числами в промежутке [-9;9]
// Найдите сумму отрицательных и сумму положительных элементов массива.

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
// Ниже представлено мое решение через 2 раздельных метода. На семинаре предлагают через массив. Интересно
/* int SumPlusArray(int[] array)           
{
    int sumplus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumplus = sumplus + array[i];
    }
    Console.WriteLine($"Сумма положительных чисел в массиве равна {sumplus}");
    return sumplus;
}
int SumMinusArray(int[] array)
{
    int summinus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) summinus = summinus + array[i];
    }
    Console.WriteLine($"Сумма отрицательных чисел в массиве равна {summinus}");
    return summinus;
}
SumPlusArray(arr);
SumMinusArray(arr);

*/
int[] SumPlusMinusElem(int[] array)
{
    int sumpositive = 0;
    int sumnegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumpositive += array[i];
        else sumnegative += array[i];
    }
    return new int[]{sumpositive, sumnegative}; // В ретерне создается новый массив из двух элементов
}

int[] sumplusminuselem = SumPlusMinusElem(arr); // В теле программы создаем массив, в который из ретерна вернутся 2 переменные
Console.WriteLine($"Сумма положительных элементов массива равна {sumplusminuselem[0]}"); // Нулевой элемент в ретерне - сумма положительных 
Console.WriteLine($"Сумма отрицательных элементов массива равна {sumplusminuselem[1]}"); // Первый элемент в ретерне - сумма отрицательных