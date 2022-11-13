/* Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.*/
/*
Console.WriteLine("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine(number1);
}
else 
{
    Console.WriteLine(number2);
}
*/
/* Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.*/


Console.WriteLine("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (max<number2)
{
     max = number2;
}
if (max<number3)
{
    max = number3;
}
Console.WriteLine($"Максимальное число {max} ");

/* Напишите программу, которая принимает на вход число и выдает, является ли число четным. */
/*
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result=(number % 2);
if (result == 0)
{
   Console.WriteLine($"Число {number} четное ");
}
else
{
    Console.WriteLine($"Число {number} нечетное "); 
}
/*
/*Напишите программу, которая принимает на вход число (N,), а на выходе показывает все четные числа от 1 до N. */
/*
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current<= number)
{
    int result = (current);
    Console.Write($"{result} ");
current = current +2;
}
*/