/*

//Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int MaxNumber(int num)
{
    int second;
    int n1 = num / 10;
    int n2 = n1 % 10;
    second = n2;
    return n2;
}
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int doubleNumber = MaxNumber(number);
Console.WriteLine($"Из числи {number} получилось {doubleNumber}");

*/

/*

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdNumber(int num)
{
    int result;

    if (num <= 99)
        result = -1;
    else
    {
        while (num > 999)
            num = num / 10;
        result = num % 10;
    }

    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = ThirdNumber(number);
Console.Write($"Получилась цифра {digit}");

*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

    if (num > 0 && num <= 7)
    {
        if (num > 5)
        {
        Console.Write("Выходной день");
        }
        else
        {
            Console.Write("Будний день");
        }
    }
    else
    {
        Console.Write("Ошибка ввода");
    }

    */


//Задача 15 вариант 2: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
   
   /*
bool DayOfWeek(int day)
{
    bool result;
    if (day == 6 ^ day == 7)
        result = true;
    else
        result = false;
        return result;
}
Console.Write("Введите день недели: ");
int day1 = Convert.ToInt32(Console.ReadLine());
bool dayWeek = DayOfWeek(day1);

if (dayWeek)
    Console.Write("Сегодня выходной!");
else
    Console.Write("Будний день");

*/