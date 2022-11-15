//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

        for(int i = 0; i < size; i++ )
            array[i] = new Random().Next(100, 999 );
        
        return array;
}
*/

void ShowArray(double[] array)
{
    for(int i =0; i< array.Length; i++ )
        Console.Write( array[i] + " ");

    Console.WriteLine(" \n ");
}

Console.WriteLine("Input a number of elements: ");
int num = Convert.ToInt32(Console.ReadLine());

/*
int Even(int[] array) 
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
        sum++;
        

    return sum; 
}


int[] myArray = CreateRandomArray(num);
ShowArray(myArray);
Console.WriteLine(Even(myArray));
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*

int oddIndex(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(i % 2 != 0)
        sum += array[i];
    return sum;    
}

int[] myArray = CreateRandomArray(num);
ShowArray(myArray);
Console.WriteLine(oddIndex(myArray));
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76



double[] DoubleRandomArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().NextDouble(),2);

    return array;
}

double difference(double[] array)
{

    double imin = 1, imax = 0;
    double sum = 0;
    for(int i = 0; i < array.Length; i++ )
    {
    if (array[i] > imax)
            imax = array[i];
        if (array[i] < imin)
            imin = array[i];
    }
      sum = imax - imin;

    return sum;
    
}

double[] myArray = DoubleRandomArray(num);
ShowArray(myArray);
Console.WriteLine(difference(myArray));



