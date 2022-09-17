// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Программа проверит является ли пятизначное число палиндромом");
Console.WriteLine ("Введите пятизначное число:");
int num5 = Convert.ToInt32(Console.ReadLine());

string Palindrom(int num)
{
    int num01 = (num/10000) % 10;
    int num02 = (num/1000) % 10;
    int num04 = (num/10) % 10;
    int num05 = (num/10000) % 10;
    string pali = "палиндромом";
    if (num01 == num05 && num02 == num04)
    {
        pali = "Число является палиндромом";
    }
    else
    {
        pali = "Число не является палиндромом";
    }
    return pali;
}

Palindrom(num5);
string itog = Palindrom(num5);
Console.WriteLine (itog);