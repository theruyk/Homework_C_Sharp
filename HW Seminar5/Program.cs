/* Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

/*

int [] CreateRandomArray(int size)  
 {
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100,1000);
        return newArray;
 }

 void ShowArray (int [] array) 
 {
    for (int i = 0; i <array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
 }

int CountEvenNum(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    
        if (array[i] % 2 == 0)
            count++;
        
    return count;
}

Console.WriteLine("Input size of array: ");
int array_size = Convert.ToInt32(Console.ReadLine());
int [] arrayCreated = CreateRandomArray(array_size);
ShowArray(arrayCreated);
int res = CountEvenNum(arrayCreated);
Console.WriteLine($"Count of even numbers:{res} ");

*/

/*Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

/*

int [] CreateRandomArray(int size)  //метод создания массива с рандомными элементами
 {
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(-100,101); // или убрать границу, тогда Random().Next()
        return newArray;
 }

 void ShowArray (int [] array)  // демонстрация массива
 {
    for (int i = 0; i <array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
 }

int SumOddNum (int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
            result = result + array[i];
    return result;
            
}

Console.WriteLine("Input size of array: ");
int array_size = Convert.ToInt32(Console.ReadLine());

int [] arrayCreated = CreateRandomArray(array_size);
ShowArray(arrayCreated);
int Summ = SumOddNum(arrayCreated);
Console.WriteLine($"Summ uneven numbers:{Summ} ");

*/

/*Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/


double [] CreateRandomArray(int array_size)  
 {
     double [] newArray = new double[array_size];

    for (int i = 0; i < array_size; i++)
        newArray[i] = new Random().Next(1,10) + new  Random().NextDouble();
        return newArray;
 }
     

 void ShowArray (double [] array) 
 {
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{Math.Round(array[i], 2)} ");
    Console.WriteLine();
 }

double DiffNum (double [] array)
{   
    double res = 0;
    double min = array[0];
    double max = array[0];
    for (int j = 0; j < array.Length; j++){

        if (array[j] > max)
            max = array[j];
        if (array[j] < min)
            min = array[j];
    res = max - min;}
    return res;
}

Console.WriteLine("Input size of array: ");
int array_size = Convert.ToInt32(Console.ReadLine());

double [] arrayCreated = CreateRandomArray(array_size);
ShowArray(arrayCreated);
double Diff = DiffNum(arrayCreated);
Console.WriteLine($"Difference of max and min: {Math.Round(Diff, 2)} ");