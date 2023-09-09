// Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли данное число в массиве.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] arr = CreateRandomArray(12, -9, 9);
Console.WriteLine();
bool NumberCheckArray(int[] array, int number)
{
    bool t = true;
    bool f = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return t;
    }
    return f;
}
Console.WriteLine("Привет! У меня в памяти 12 случайных чисел. Введи свое и проверим, есть ли оно в моей памяти");
int numb = Convert.ToInt32(Console.ReadLine());
bool check = NumberCheckArray(arr,numb);
if (check == true) Console.WriteLine("Твое число было в моей памяти");
else Console.WriteLine("Твоего числа в моей памяти не было");
Console.WriteLine("А массив был таков:");
PrintArray(arr);