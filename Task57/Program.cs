// Задача 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных.

int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // можно было через i < rows;
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("   |");
    }
}
int[,] array2d = CreateRandomMatrix(5, 5, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();

int[] MatrixIntoArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)]; // А можно было matrix.Length использовать.
    int tempsum = 0;                                                  // Эта хрень выдает количество элементов в массиве!

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[tempsum] = matrix[i, j];
            tempsum++;
        }
    }
    return array;
}
int[] arr = MatrixIntoArray(array2d);
Array.Sort(arr);
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
PrintArray(arr);
Console.WriteLine();
void FrequencyDictionary(int[] sortedarray)
{
    int sum = 1;
    int currentnum = sortedarray[0];
    for (int i = 1; i < sortedarray.Length; i++)
    {
        if (sortedarray[i] == currentnum)
        {
            sum++;
        }
        else
        {
            Console.WriteLine($"Элемент {currentnum} встречается {sum} раз");
            sum = 1;
            currentnum = sortedarray[i];
        }
    }
    Console.WriteLine($"Элемент {currentnum} встречается {sum} раз"); // Т.к цикл for закончился, то в else мы уже не попали, поэтому
                                                                      // надо отдельно вывести последнее число из цикла.
}
FrequencyDictionary(arr);