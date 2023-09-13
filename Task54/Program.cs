// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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

void RowMatrixSorter(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int q = 0; q < matrix.GetLength(1) - 1; q++)
            {
                if (matrix[i,q] < matrix[i, q+1])
                {
                    temp = matrix[i,q];
                    matrix[i,q] = matrix[i,q+1];
                    matrix[i,q+1] = temp;
                }
            }
        }
    }
}

RowMatrixSorter(array2d);
PrintMatrix(array2d);