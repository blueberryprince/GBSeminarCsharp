// Задача 49. Найти элементы массива, у которых оба индекса четные, и заменить их на квадраты чисел.

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
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("   |");
    }
}
void PowEvenIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2) // можно было через i < rows;
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}
int[,] array2d = CreateRandomMatrix(5, 5, -9, 9);
PrintMatrix(array2d);
PowEvenIndex(array2d);
Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();