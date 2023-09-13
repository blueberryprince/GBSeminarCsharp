// Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void RowsSwapMatrix(int[,] matrix)
{
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = 0;
            temp = matrix[0,j];
            matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
            matrix[matrix.GetLength(0)-1,j] = temp;
        }
}
int[,] array2d = CreateRandomMatrix(4, 5, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();
RowsSwapMatrix(array2d);
PrintMatrix(array2d);