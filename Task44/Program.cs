// Задача 44. Вывести первые N чисел Фибоначчи не используя рекурсию. Первые два числа - 0 и 1.

void Validation(int a)
{
    if (a < 2) return;
}
int[] Fibonacci(int a)
{
    int[] array = new int[a];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < a; i++)
    {
        checked
        {
            array[i] = array[i-1] + array[i-2];
        }
    }
    return array;
}

Console.WriteLine("Введите число больше 2");
int number = Convert.ToInt32(Console.ReadLine());
Validation(number);
int[] arr = Fibonacci(number);
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
PrintArray(arr);

