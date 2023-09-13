// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] RowSum(int[,] matrix)
{
    int[] sumarray = new int[matrix.GetLength(0)];
    int sum;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        sumarray[i] = sum;
    }
    return sumarray;
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
int[] arrayofsum = RowSum(array2d);
PrintArray(arrayofsum);
Console.WriteLine();
void FindMinSum(int[] array)
{
    int min = array[0];
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
            count = i;
        }
    }
    Console.WriteLine($"Минимальная построковая сумма находится в строке {count}");
}
FindMinSum(arrayofsum);