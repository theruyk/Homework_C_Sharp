//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*

double [,] Create2dArray(int row, int column, int minVal, int maxVal) // создание 2х мерного массива
{
  double[,] created2dArray = new double[row, column];
  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      created2dArray[i, j] = Math.Round(new Random().Next(minVal, maxVal + 1) + new Random().NextDouble(),1);
  return created2dArray;
}
void Show2dArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " "); // вывод значений
    }
    Console.WriteLine();  // переход на новую строку
  }
Console.WriteLine(); // отступ от массива
}


Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] newArray = Create2dArray(rows, columns, min, max);
Show2dArray(newArray);

*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в
//двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] CreateArray( int row, int column, int min, int max)
{
  int [,] newArray  = new int[row,column];
  for (int i = 0; i < row; i++ )
    for(int j = 0; j < column; j++)
      newArray[i,j] = new Random().Next(min, max +1);
      return newArray;
}

void ShowArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " "); // вывод значений
    }
    Console.WriteLine();  // переход на новую строку
  }
Console.WriteLine(); // отступ от массива
}

void FindElem(int [,] array, int numberRow, int numberColumn)
{
  if (numberRow < 0 || numberColumn < 0 || numberRow > array.GetLength(0) || numberColumn > array.GetLength(1))
  {Console.WriteLine(" Index was outside the bounds of the array");}
  else
      {
        int Elem = array[numberRow,numberColumn];
        Console.WriteLine(Elem);
      }
}

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min num ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max num ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of row: ");
int numberRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of column: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());

int [,] CreatedArray = CreateArray(rows, columns, min, max);
ShowArray(CreatedArray);

FindElem(CreatedArray,numberRow,numberColumn);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
 void ShowArray2 (double [] array) 
 {
    for (int i = 0; i <array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
 }

int [,] CreateArray( int row, int column, int min, int max)
{
  int [,] newArray  = new int[row,column];
  for (int i = 0; i < row; i++ )
    for(int j = 0; j < column; j++)
      newArray[i,j] = new Random().Next(min, max +1);
      return newArray;
}

void ShowArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " "); // вывод значений
    }
    Console.WriteLine();  // переход на новую строку
  }
Console.WriteLine(); // отступ от массива
}

double [] MidleArifm(int [,] array)

{
  double [] MidleSum = new double [array.GetLength(1)];
  for(int j = 0; j < array.GetLength(1); j++)
  {
    double Summ =0;
      for (int i = 0; i < array.GetLength(0); i++)
      {
        Summ += array[i,j];
      }
    MidleSum [j] = Math.Round(Summ/array.GetLength(0),2);
  }
return MidleSum; 
}

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min num ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max num ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] CreatedArray = CreateArray(rows, columns, min, max);
ShowArray(CreatedArray);

ShowArray2 (MidleArifm(CreatedArray));
