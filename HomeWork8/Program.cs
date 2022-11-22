// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// Пузырьковая сортировка

// int[,] CreateRandomArray(int crow, int columns)
//     {
//         int[,] array = new int[crow,columns];

//         for(int i = 0; i < crow; i++)
//             for(int j = 0; j < columns; j++)    
//         array[i,j] = new Random().Next(1,10);
//         return array;
//     }

// void Show2dArray(int[,] array)
//     {
//         for(int i = 0; i < array.GetLength(0); i++)
//         {   
//             for(int j = 0; j < array.GetLength(1); j++)
               
//                 Console.Write(array[i,j] + " ");
//                 Console.WriteLine();
//         }

//         Console.WriteLine();        

//     }

// Console.WriteLine("Input a crow");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a columns");
// int m = Convert.ToInt32(Console.ReadLine());


// int [,] myArray = CreateRandomArray(n,m);
// Show2dArray(myArray);    

// void NewArray(int[,] array)
// {
//     for(int i = 0; i <  array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1) ; j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if( array[i,k + 1] > array[i,k] )
//                 {
//                     int imax = array[i,k +1];
//                     array[i,k + 1 ] = array[i,k ];
//                     array[i,k ] = imax;
//                 }
//             }
//         }
//     }  
  
// }


// NewArray(myArray);
// Show2dArray(myArray);    





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int SumArray(int [,] array)
{
    int sum =0;
    int line = 0; 
    int minsum = 0;
    int l = 0;
    for( int i = 0; i < array.GetLength(0); i ++)
     {
        for( int j = 0; j < array.GetLength(1); j ++)
            sum += array[i,j];
            if(line == 0)
            {
                minsum = sum;
            }
            line++;
            //Console.WriteLine($"{line} {sum}"); //проверка подсчетов 
            if(sum < minsum)
            {   
                minsum = sum;
                l = line;
                sum =0;
            }    
            else    
            sum = 0;
     }
      return l ;
}
Console.WriteLine($" {SumArray(myArray)} ");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateRandomArray(int crow, int columns)
    {
        int[,] array = new int[crow,columns];

        for(int i = 0; i < crow; i++)
            for(int j = 0; j < columns; j++)    
        array[i,j] = new Random().Next(1,10);
        return array;
    }

void Show2dArray(int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {   
            for(int j = 0; j < array.GetLength(1); j++)
               
                Console.Write(array[i,j] + " ");
                Console.WriteLine();
        }

        Console.WriteLine();        

    }
Console.WriteLine("Input a crow first maxrix");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a first matrix columns and crow second matrix");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second matrix columns");
int k = Convert.ToInt32(Console.ReadLine());

int [,] productarray = new int[n,k];

    void  MatrixProduct(int [,] myArray,int [,] my2Array,int [,] productarray)
    {
        for(int i = 0; i < productarray.GetLength(0);i++)
        {  for(int j = 0; j < productarray.GetLength(1);j++)
            {   
                int sum = 0;
                for(int k = 0; k < myArray.GetLength(1);k++ )
                { 
                 sum +=  myArray[i,k] * my2Array[k,j];
                }
                productarray[i,j] = sum;
            }
        }
         
    }



int [,] myArray = CreateRandomArray(n,m);
Show2dArray(myArray);    
int [,] my2Array = CreateRandomArray(m,k);
Show2dArray(my2Array);
MatrixProduct(myArray,my2Array,productarray);
Show2dArray(productarray);












// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
Console.WriteLine("Input a crow");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a columns");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a page");
int v = Convert.ToInt32(Console.ReadLine());

int[,,] CreateRandome3DArray(int rows,int cloumns,int page)
{
    int[,,] array = new int [rows, cloumns, page];

    int number = 10;

    for(int i = 0; i < rows; i ++)
    {   
        for(int j = 0; j < cloumns; j++)
        {  
            for(int k = 0; k < page; k++)
            {   
                array[i,j,k] = number++;
                
                
                
            }    
        }        
    }          
    return array;             
}

void Show3DArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++)
    {   
        for(int j = 0; j < array.GetLength(2); j++)
        {
                for(int k = 0; k < array.GetLength(1); k++)
                {    
                    Console.WriteLine($"{array[i,j,k]} ({i}{k}{j}) ");
                }
        }
    }     
          
}


int [,,] my3DArray = CreateRandome3DArray(n,m,v);
Show3DArray(my3DArray);



*/
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



/*
int[,] CreateRandomArray(int crow, int columns)
    {
        

        int[,] array = new int[crow,columns];
            int sum= 1;
            int i = 0;
            int j =0;

        while (sum <= array.GetLength(0) * array.GetLength(1))
        {
        array[i, j] = sum;
            sum++;
            if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                j++;
            else if (i < j && i + j >= array.GetLength(0) - 1)
                i++;
            else if (i >= j && i + j > array.GetLength(1) - 1)
             j--;
            else
                i--;
        }
        return array;
    
    }



void Show2dArray(int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {   
            for(int j = 0; j < array.GetLength(1); j++)
               
                Console.Write(array[i,j] + " ");
                Console.WriteLine();
        }   
        Console.WriteLine();        

    }

Console.WriteLine("Input a crow");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a columns");
int m = Convert.ToInt32(Console.ReadLine());


int [,] myArray = CreateRandomArray(n,m);
Show2dArray(myArray);    
*/