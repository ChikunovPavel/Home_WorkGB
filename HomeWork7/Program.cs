// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] CreateRandomArray(int rows, int columns)
{
    double[,] array = new double[rows,columns]; 
        for(int i = 0; i < rows; i ++)
            for(int j = 0; j < columns; j++)
                array[i,j] = Math.Round(new Random().NextDouble(),3);
    return array;              
}

void ShowArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
    Console.WriteLine();
    }   
Console.WriteLine(); 
}

Console.WriteLine("Input a n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a n");
int m = Convert.ToInt32(Console.ReadLine());


double[,] myArray = CreateRandomArray(n,m);
ShowArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
/*

int[,] CreateRandomArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 10);
    return array;

}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.WriteLine("Input a n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a n");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a n");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a n");
int num2 = Convert.ToInt32(Console.ReadLine());

void ShowNumber(int[,] array)
{
    if (num1 > n || num1 > m)
        Console.WriteLine("there is no file with indexes in the array");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
             if (i == num1 && j == num2)
                Console.WriteLine(array[i, j]);

    }
}

int[,] myArray = CreateRandomArray(n, m);
ShowArray(myArray);
ShowNumber(myArray);

*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
Console.WriteLine("Input a n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a n");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a n");


int [,] CreateRandomArray(int rows, int columns)
{
    int[,] array = new int [rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(1,10);
    return array;        
}

void ShowArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] ArithmeticalMean(int [,] array)
 {
    double[] newArray = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1);j++)
    {
        for(int i = 0; i < array.GetLength(0);i++)
         {  
             newArray[j] += array[i,j];
         } 
        newArray[j] /= array.GetLength(0);
        Console.WriteLine($"Mean:{j+1}={Math.Round(newArray[j],2)}");

               
    } 
    // Console.WriteLine( newArray);       
    return newArray;        
 }




int[,] myArray = CreateRandomArray(n, m);
ShowArray(myArray);
ArithmeticalMean(myArray);

*/