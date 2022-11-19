
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
Palindrom(num);
*/