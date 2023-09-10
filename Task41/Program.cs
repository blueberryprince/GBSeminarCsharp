// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] NotSoRandomArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
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
    Console.WriteLine();
}
Console.WriteLine("Приветствую! Эта программа находит число чисел > 0 в произвольно заданном массиве");
Console.WriteLine("Введите число элементов массива, который вы хотите произвольно задать");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводите элементы массива");
int[] userarray = NotSoRandomArray(size);
Console.WriteLine("Итоговый вид вашего массива:");
PrintArray(userarray);

void CheckForPositives(int[] checkarray)
{
    int sum = 0;
    for (int i = 0; i < checkarray.Length; i++)
    {
        if (checkarray[i] > 0) sum++;
    }
    Console.WriteLine($"Число чисел > 0 в вашем массиве равно {sum}");
}
CheckForPositives(userarray);
