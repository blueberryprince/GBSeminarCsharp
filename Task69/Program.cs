// Задача 69. Напишите программу, которая на вход принимает два числа А и Б и возводит число А в натуральную степень Б.

Console.WriteLine("Введите число А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Б");
int numB = Convert.ToInt32(Console.ReadLine());


if (numB < 0)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
int PowAtoB(int numA, int numB) // 3,5  3,4 3,3 3,2 3,1 3,0
{
    if (numB == 0) return 1;
    return numA * PowAtoB(numA, numB - 1); // 3,5 3,4 3,3   3,2 3,1 1
}                                          // 3*3*3*3*3*1(из ретерна) = 243
int result = PowAtoB(numA, numB);
Console.WriteLine(result);