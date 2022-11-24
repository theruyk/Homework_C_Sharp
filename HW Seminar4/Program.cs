//Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
/*
void Stepenb (int A, int B)
{
    int result = A;
    for (int i =1; i < B; i++)
    {
        result *= A;
    }
    Console.WriteLine ($"А в степени B: {result}");
}


Console.WriteLine ("Input number A: ");
int numberA = Convert. ToInt32(Console. ReadLine());

Console.WriteLine ("Input number B: ");
int numberB = Convert. ToInt32(Console. ReadLine());

Stepenb (numberA,numberB);
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

void SumInNum (int n)
{
    int current = n;
    int res = 0;
    while (current != 0)
    {
        
        int num = current % 10;
        current = current/10;
        res = res + num;
        
    }
    Console.WriteLine ($"{res}");
}


Console.WriteLine ("Input number: ");
int number = Convert. ToInt32(Console. ReadLine());
SumInNum(number);

*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] NewArray()
{
    int [] array = new int [8]; 
    for (int i = 0; i < 8; i++ )
    array[i] = new Random().Next();
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}, ");
    }
}
ShowArray(NewArray());