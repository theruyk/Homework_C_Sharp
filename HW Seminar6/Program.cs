/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

/*

int[] Array(int size)
{
  int[] newArray = new int[size];
  for (int i = 0; i < size; i++)
  {
    Console.WriteLine("Input your number ");
    newArray[i] = Convert.ToInt32(Console.ReadLine());
  }
  return newArray;
}

void ShowArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
  Console.WriteLine();
}

int PositiveArray(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
      count++;
  }
  return count;
}

Console.WriteLine("Input size of array ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arrayCreated = Array(size);
ShowArray(arrayCreated);

Console.WriteLine($"Positive numbers is: {PositiveArray(arrayCreated)}  ");


//Console.WriteLine("Array data:");
*/


/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double StrangeTaskx(double k1, double k2, double b1, double b2)
{
  double x;
  {
    x = (b2 - b1) / (k1 - k2);

    return x;
  }
}
double StrangeTasky(double k1, double b1, double x)
{
  double y;
  {
    y = k1 * x + b1;
    return y;
  }
}

Console.WriteLine("Imput k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Imput k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
{
  Console.WriteLine("K1 is equal to K2. Two lines have no common point");
  
}
else
{
  Console.WriteLine("Imput b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Imput b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"The common point of intersecting lines is x = {Math.Round(StrangeTaskx(k1, k2, b1, b2), 2)} ");
Console.WriteLine($"y = {Math.Round(StrangeTasky(k1, b1, StrangeTaskx(k1, k2, b1, b2)), 2)} ");
}

