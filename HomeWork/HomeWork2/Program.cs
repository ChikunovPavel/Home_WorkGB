//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.WriteLine("Введите трех значное число:");
int num = Convert.ToInt32(Console.ReadLine());

int Show(int number)
{
    int result = number / 10 % 10;
    return result; 
}

int newnum = Show(num);

Console.WriteLine($"Введенное число: {num} Вторая цифра: {newnum}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

string number = Convert.ToString(num);

if (number.Length > 2)
    {
        Console.WriteLine("третья цифра  " + number[2]);
    }
else 
    {
        Console.WriteLine("-> третьей цифры нет");
    }

*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Введите цифру дня недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

void Calendar(int number)
{
    if( number ==6 || number == 7)
    {
    Console.WriteLine("Это выходной");
    }
    else
    {
    Console.WriteLine("Это будний день");
    }
}

Calendar(day);
*/

