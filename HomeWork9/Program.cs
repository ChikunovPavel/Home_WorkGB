// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums( n -1);
    
}
ShowNums(10);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
Console.WriteLine("Input a number m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number n:");
int n = Convert.ToInt32(Console.ReadLine());


int ShowSum(int m, int n)
{
    if(n >= m) 
        return ShowSum(m, n-1) + n;
    return 0;
}

Console.WriteLine(ShowSum(m,n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//          m+1,             if  n == 0;
// A(n,m)=A(n-1,1),          if  n != 0, m = 0;
//        A(n-1,A(n,m - 1)), if  n >  0, m > 0;

Console.WriteLine("Input a number n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number m:");
int m = Convert.ToInt32(Console.ReadLine());


int Akkerman(int n,int m)
{
    if(n == 0) 
    {
         return m+1;
    }
        else if(n != 0 && m == 0 )
        { 
            return Akkerman(n-1,1);
        }
            else if (n > 0 &&  m > 0) 
            { 
                return Akkerman(n-1,Akkerman(n,m-1));
            }
    return 0;
}

Console.WriteLine(Akkerman(n,m));
