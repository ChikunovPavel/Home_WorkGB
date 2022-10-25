//Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите  число:");
int num = Convert.ToInt32(Console.ReadLine());

int Show(int number)
{
    int result = 0;
    while(number > 0)
    {
        number = number / 10;
        result++;
    }
    return result; 
}

int amount = Show(num);// количество цифр в числе

int division(int number)
{
    int result = 1;
    while(number > 0)
    {
        result=result*10;
        number--;
    }
    return result;

}

int divi = division(amount);
int newdivi = divi / 10; // число на которое будем  делить
int percent = 10;

if( num / newdivi == num % percent)// решение 
    {
    while(newdivi == 0)
     newdivi = newdivi / 10;
     percent = percent * 10;
     if((num / newdivi) % percent == (num % percent)/10) 
    
     Console.WriteLine("это полиндром");    
    }
    else
    Console.WriteLine("это не полиндром");
*/
           

//Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
*/


//Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
*/