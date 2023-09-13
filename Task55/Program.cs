// Задача 55.Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

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

void TranspondMatrix(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++) // Получается, идет свап только по нижнему треугольнику (который ниже диагонали)
        {
                temp = 0;
                temp = matrix[i,j];
                matrix[i,j] = matrix[j,i];
                matrix[j,i] = temp;
            
        }
    }
}
bool Validation(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}
int[,] array2d = CreateRandomMatrix(5, 5, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();
if (Validation(array2d) == true) // Можно сделать через !Validation(array2d) и написать сообщение. А типа в else уйдет проход функции
// Тут типа будет логическое отрицание. Т.е если выражение true, то тут оно преобразуется в false и пролетает. 
{
    TranspondMatrix(array2d);
    PrintMatrix(array2d);
}
else 
{
    Console.WriteLine("Невозможно заменить строки на столбцы");
    return;
}