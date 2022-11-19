//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*     // Решение задачи без массива

Console.WriteLine("Input a amount of number:");
int M = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for(int i = 0; i < M; i++)
    {
        Console.WriteLine("Input number:");
        int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0)
                sum++;
    }

Console.WriteLine($"number > 0:\n{ sum }");
*/
/*    // Решение задачи с применением массива

Console.WriteLine("Input a amount of number");
int M = Convert.ToInt32(Console.ReadLine());

int[] CreateNewArray(int size)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
      array[i] = Convert.ToInt32(Console.ReadLine()); 
    return array;  
  
}
void ShowArray(int[] array)
{
    for(int i = 0;i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
    Console.WriteLine( );
}

int Sum(int[] array )
{
    int sum = 0;
    for(int i =0; i< array.Length; i++)
        if(array[i] > 0)
        sum++;
    return sum;
}
int[] myArray = CreateNewArray(M);
ShowArray(myArray);
Console.WriteLine(Sum(myArray));
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y=k1 * x + b1
// y=k2 * x + b2
// k1*x + b1 = k2*x + b2
// x =(b2-b1)/(k1-k2)
//(x,y) 


/*
Console.WriteLine("Input a b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
double y1 = k2 * x + b2;
if (y == y1)
    Console.WriteLine($" x = {x} y = {y} y2 = {y1}\nЛинии паралельны");
if (y != y1)
    Console.WriteLine($" x = {x} y = {y} y2 = {y1}\nЛинии пересекаются");
*/






