// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

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

int[,] array2d = CreateRandomMatrix(4, 5, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();

int[] FindIndexesOfMinElement(int[,] matrix)
{
    int minrow = 0;
    int mincolumn = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minrow = i;
                mincolumn = j;
            }
        }
    }
    return new int[] { minrow, mincolumn };
}
int[] minarray = FindIndexesOfMinElement(array2d);

int[,] DeletedMinRowsMinColumnsMatrix(int[,] matrix, int rowmin, int colmin)
{
    int m = 0; // Счетчик строк для исходной матрицы;
    int n = 0; // Счетчик столбцов для исходной матрицы;
    int[,] newmatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        if (m == rowmin) m += 1; // Проверка на удаляемую строку и перескок.
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (n == colmin) n += 1; // Проверка на удаляемый столбец и перескок.
            newmatrix[i, j] = matrix[m, n];
            n++; // Увеличиваем столбцы;
        }
        m++; // Увеличиваем строки;
        n = 0; // Обнуляем столбцы.
    }
    return newmatrix;
}
int[,] updatedmatrix = DeletedMinRowsMinColumnsMatrix(array2d, minarray[0], minarray[1]);
PrintMatrix(updatedmatrix);