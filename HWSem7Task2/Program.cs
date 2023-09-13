int[,] CreateStrangeMatrix(int rows, int columns, int k)
{
    int[,] matrix = new int[rows, columns];
    matrix[0,0] = 1;
    for (int i = 1; i < matrix.GetLength(0); i++)
    { 
        matrix[i,0] = ((columns)*k)*i+matrix[0,0];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = matrix[i,j-1] + k;
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
int[] FindNumberByPosition(int[,] matrix, int rowposition, int columnposition)
{
        int[] array = new int[2];
        if (rowposition > matrix.GetLength(0) || columnposition > matrix.GetLength(1) || rowposition < 0 || columnposition < 0)
        array[0] = 0;
        else
        {
            array[0] = matrix[rowposition, columnposition];
            array[1] = 0;
        }  
        return array;
}
int[,] array2d = CreateStrangeMatrix(5, 6, 3);
PrintMatrix(array2d);
Console.WriteLine();
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int[] checkarray = new int[2];
checkarray = FindNumberByPosition(array2d,x,y);
Console.WriteLine(checkarray[0]);
