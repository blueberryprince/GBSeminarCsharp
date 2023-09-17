// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите 2 неотрицательных натуральных числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < 0 || num2 < 0)
    {
        Console.WriteLine("Некорректный ввод");
        return;
    }

int AkkermanFunction(int num1, int num2)
{
    if (num1 == 0) return num2+1;
    else if (num2 == 0) return AkkermanFunction(num1-1,1);
    else return AkkermanFunction(num1-1, AkkermanFunction(num1,num2-1));
}

int result = AkkermanFunction(num1, num2);

Console.WriteLine(result);