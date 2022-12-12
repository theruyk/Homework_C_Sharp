//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

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

void OrderlyArray(int [,] CreatedArray)
{
for (int i = 0; i < CreatedArray.GetLength(0); i++)
    for (int j = 0; j < CreatedArray.GetLength(1); j++)
    {
      for (int k = 0; k < CreatedArray.GetLength(1) - 1; k++)
        {
          if (CreatedArray[i, k] < CreatedArray[i, k + 1])
            {
              int temp = CreatedArray[i, k + 1];
              CreatedArray[i, k + 1] = CreatedArray[i, k];
              CreatedArray[i, k] = temp;
            }
        }
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

int [,] CreatedArray = CreateArray(rows, columns, min, max);
ShowArray(CreatedArray);

OrderlyArray(CreatedArray);
ShowArray(CreatedArray);

*/
//Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*

void ShowArray1(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($" {array[i]}, ");
  }
}


int[,] CreateArray(int row, int column, int min, int max)
{

  int[,] newArray = new int[row, column];
  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      newArray[i, j] = new Random().Next(min, max + 1);
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
int[] SumResult(int[,] CreatedArray)
{

  int[] array = new int[CreatedArray.GetLength(0)];
  for (int i = 0; i < CreatedArray.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < CreatedArray.GetLength(1); j++)
    {
      sum = sum + CreatedArray[i, j];
    }
    array[i] = sum;
  }
  return array;
}

void MaxOfRows(int[] array)
{
  int min =array[0];
  int index = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < min)
    {
      min = array[i];
      index = i;
    }

  }
  Console.WriteLine();
  Console.WriteLine($"Cтрокa с наименьшей суммой элементов: {index}");
}


Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min num ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max num ");
int max = Convert.ToInt32(Console.ReadLine());


if (rows ==columns)
    Console.WriteLine("array is not rectangular");
  else
{int[,] CreatedArray = CreateArray(rows, columns, min, max);
ShowArray(CreatedArray);

SumResult(CreatedArray);
ShowArray1(SumResult(CreatedArray));

MaxOfRows(SumResult(CreatedArray));
}
*/


//Задача 58(дополнительно): Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



//Задача 60(дополнительно): ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralArray(int row, int column)
{
  int[,] SpiralArray1 = new int[row, column];
  int num = 1;
  int iMin = 0;
  int iMax = row;
  int jMin = 0;
  int jMax = column;
  while (iMin < iMax && jMin < jMax)
  {
    int i = iMin;
    int j = jMin;
    for (j = jMin; j < jMax; j++)
    {
      SpiralArray1[i, j] = num;
      num++;
    }
    j = jMax - 1;
    for (i = iMin + 1; i < iMax; i++)
    {
      SpiralArray1[i, j] = num;
      num++;
    }
    i = iMax - 1;
    for (j = jMax - 2; j >= jMin; j--)
    {
      SpiralArray1[i, j] = num;
      num++;
    }
    j = jMin;
    for (i = iMax - 2; i > iMin; i--)
    {
      SpiralArray1[i, j] = num;
      num++;
    }
  iMin++;
  jMin++;
  iMax--;
  jMax--;
}
  return SpiralArray1;
}


void ShowArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + "\t"); // вывод значений
    }
    Console.WriteLine();  // переход на новую строку
  }
  Console.WriteLine(); // отступ от массива 
}

Console.Write("Input count of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Input count of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = SpiralArray(row, column);
ShowArray(array);

