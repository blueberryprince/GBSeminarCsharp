// Задача 48. Задайте двумерный массив размером M x N. Заполните его элементами по формуле Amn = m+n. 
// Выведите массив на экран

int[,] CreateStrangeMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++) // можно было через i < rows;
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
int[,] array2d = CreateStrangeMatrix(3, 4);
PrintMatrix(array2d);
Console.WriteLine();