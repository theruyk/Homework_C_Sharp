
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

/*

void Palindrom(int number)
{
    int number1 = number;
    int Reverse = 0;
    while (number != 0){
        int end = number % 10;
        Reverse = (Reverse * 10) + end;
        number = number / 10;
    }

    if (number1 == Reverse && Reverse !=0 ){
        Console.WriteLine("Yes");
    }
    else {Console.WriteLine("No");}

}

Console.WriteLine("Input your number ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num <100000)
    {
    Palindrom(num);
    }
else Console.WriteLine("Input five-digit number ");

*/

// Напишите программу, которая принимает на вход координыты
//двух точек и находит расстояние между ними в 3D пространстве.

/*

double LongLine(int x1, int y1, int x2, int y2, int z1, int z2)

{
int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;
double lengthAB = Math. Round (Math.Sqrt (x*x + y*y + z*z), 3);
return lengthAB; 
}
Console.WriteLine ("input X coordinat of A: ");
int xA = Convert. ToInt32(Console. ReadLine());
Console.WriteLine ("input Y coordinat of A:");
int yA = Convert. ToInt32(Console. ReadLine());
Console.WriteLine("input X coordinat of B:");
int xB = Convert. ToInt32(Console. ReadLine ( ));
Console.WriteLine("input Y coordinat of B:");
int yB = Convert. ToInt32(Console.ReadLine ());
Console.WriteLine ("input Z coordinat of A: ");
int zA = Convert. ToInt32(Console. ReadLine());
Console.WriteLine("input Z coordinat of B:");
int zB = Convert. ToInt32(Console.ReadLine ());


double dist = LongLine(xA, yA, xB, yB, zA, zB);

Console.WriteLine($"Distance AB is {dist}");

*/









// Напишите программу, которая принимает на вход число
// N и выдает таблицу кубов чисел от 1 до N.

