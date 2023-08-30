// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Эта программа создает массив из 8 случайных чисел, вот он: ");
void ArrayCreator()
{
    int[] array = new int[8];
    var random = new Random();
    int i = 0;
    while (i<8)
    {
        array[i] = random.Next(1000);
        Console.Write(array[i]+" ");
        i++;
    }
}
ArrayCreator();