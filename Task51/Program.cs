// Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали.

int[,] InputMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // можно было через i < rows;
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
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
void SumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // можно было через i < rows;
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==j) sum = sum + matrix[i,j];
        }
    }
    Console.WriteLine($"Сумма элементов, находящихся на главной диагонали, равна {sum}");
}
Console.WriteLine("Введите число строк в матрице");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов в матрице");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь начинается заполнение матрицы. Заполнение построчное. Вводите значения для заполнения");
int[,] array2d = InputMatrix(rows,columns);
Console.WriteLine("Ваша матрица выглядит так:");
PrintMatrix(array2d);
SumMainDiagonal(array2d);