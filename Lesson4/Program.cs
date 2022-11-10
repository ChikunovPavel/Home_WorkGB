// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
Console.WriteLine("Введите числло А");
int num = Convert.ToInt32(Console.ReadLine());


int summa (int number)
{
    int sum = 0;

    for(int a = 1; a <= number ; a++)
        sum += a;
        return sum;
}

Console.WriteLine(summa(num));
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int ostatok (int number)
{
    int result = 0;
    if(number == 0)
    {
      result = 1;
    }

    while (number != 0)
    {
     number /= 10;
     result++;
    }
    return result;
}

Console.WriteLine(ostatok(num));

*/
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int work (int number)
{
    int sum = 1;

    for(int a = 1; a <= number; a ++)
        sum *= a;
        return sum;
    
}

Console.WriteLine(work(num));
*/


//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int [] CreateRandomeArray(int size, int minValue,int maxValue )
{
    int[] array = new int[size];
    for(int i = 0; i< size; i++)
        array[i] =new Random().Next(minValue,maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++ )
        Console.Write(array[i] + " " );

       
}

Console.WriteLine("Imput a number of elements:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a min possible value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomeArray(n,min,max);
ShowArray(myArray);
