//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowDigits (int n)
{
  if (n>=1)
  {
    Console.Write((n)+ ", ");
    n--;
    ShowDigits(n);
  }
  else Console.Write("\b\b");
}

Console.Write("Input num: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowDigits(n);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*

int SumElements(int m, int n)

{
  if (m < n)
    return m + SumElements(m + 1, n);
  else if (m > n)
    return m + SumElements(m - 1, n);
  else return n;
}

void Positive(int m, int n)
{
  if (m < 0 || n < 0)
    Console.WriteLine("Imput positive numbers");
  else
  {
    int Summ = SumElements(m, n);
    Console.WriteLine(Summ);
  }
}

Console.Write("Input num m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input num n: ");
int n = Convert.ToInt32(Console.ReadLine());

Positive(m, n);

*/

//Задача 68: дополнительно Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29







//Задача: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную


void FromDecinBin(int n)
{  
  if (n == 0) return;
  FromDecinBin(n / 2);
  if (n % 2 == 0) Console.Write(0);
  else Console.Write(1);
}
  Console.Write("Input num: ");
  int n = Convert.ToInt32(Console.ReadLine());

  FromDecinBin(n);
