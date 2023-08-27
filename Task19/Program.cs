bool Palindrome(int number)
{
    int firstdigit = number / 10000;
    int seconddigit = number / 1000 % 10;
    int thirddigit = number / 100 % 10;
    int fourthdigit = number / 10 % 10;
    int fifthdigit = number % 10;
    if (firstdigit == fifthdigit && seconddigit == fourthdigit)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
bool check = Palindrome(n);
Console.WriteLine(check == true ? "Да" : "Нет");
