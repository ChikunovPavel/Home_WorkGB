//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень:");
int b = Convert.ToInt32(Console.ReadLine());

int degrre(int number)
{
    int sum = 1;

    for(int count = 1; count <= number; count++)
        sum = sum * a;
    return sum;
}
        
Console.WriteLine(degrre(b));
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int total(int number)
{
    int sum = 0;
    int current = 0;
    
    while(number != 0)
    {
    current = number % 10;
    number /= 10;
    sum += current;
    }
    return sum;
}
 Console.WriteLine(total(num));
 */

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*
Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] CreateArray (int size, int value )
    {
        int[] array = new int[size];
        for(int i = 0; i < size ; i++)
            array[i] = Convert.ToInt32(Console.ReadLine());
        return array;    
    }
void ShowArray(int[] array)    
    {
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i]  +" ");
    }
int[] myArray = CreateArray(n,num);
ShowArray(myArray);
/*