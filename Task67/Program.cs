// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigitsNumberRec(int number) // Функция. 114  11  1   0
{
    if (number == 0) return 0;
    return number%10 + SumDigitsNumberRec(number / 10); // Стэк. 114    11  1
    // 1%10 + 11%10 + 114%10 = 1+1+4+0 (0 пришел из ретерна) = 6
}
int result = SumDigitsNumberRec(number);
Console.WriteLine(result);