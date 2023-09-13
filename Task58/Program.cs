// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
int[,] matrix1 = CreateRandomMatrix(3, 5, -9, 9);
int[,] matrix2 = CreateRandomMatrix(5, 4, -9, 9);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();

bool Validation(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
}

int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int[,] multimatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            multimatrix[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                multimatrix[i, j] += matrix1[i,k] * matrix2[k,j];
            }
            
        }
    }
    return multimatrix;
}
if (Validation(matrix1, matrix2) == true)
{
    int[,] multimatrix = MatrixMultiply(matrix1, matrix2);
    PrintMatrix(multimatrix);
}
else Console.WriteLine("Такие матрицы перемножить нельзя");