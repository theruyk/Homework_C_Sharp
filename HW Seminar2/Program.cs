// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.(С проверкой на трехзначное число ) 
//Первый вариант
/*
void DelHunAndEd(int num) 
{  
    if (num > 99 && num < 1000){
        int num_dec = num / 10;
        int result = num_dec % 10;
        Console.WriteLine($"The second number is {result} ");
    }
    else Console.WriteLine("The number is not three digits");
  
}
Console.WriteLine("Input your three-digit number ");
int number = Convert.ToInt32(Console.ReadLine());
DelHunAndEd(number);
*/

//Второй вариант через отображение -1
/*
int  DelHunAndEd() 
{   
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 99 && num < 1000){
        int num_dec = num / 10;
        int result = num_dec % 10;
        return result;
    }
    else return (-1);
}
Console.WriteLine("Input your three-digit number ");
Console.WriteLine($"The second number is {DelHunAndEd()} ");
*/

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNum(int number){
    if (number < 0){
        number = number * (-1);
    }
    if (number < 100){
        Console.WriteLine("There isn`t third number");}
        else
        {
    int Reverse = 0;
    while (number != 0){
        int end = number % 10;
        Reverse = (Reverse * 10) + end;
        number = number / 10;
    }

    int hun = Reverse % 1000;
    int Third = hun / 100;
    Console.WriteLine($"The third number is {Third}");}
    }
    

Console.WriteLine("Input your number ");
int num =Convert.ToInt32(Console.ReadLine());
ThirdNum(num);


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет является ли этот день выходным.(Проверка на количество дней недели)
/*
void Week (int num){
    if (num > 0 && num < 8)
    {

        if (num < 6){
            Console.WriteLine($"No");

        }
        else Console.WriteLine($"Yes");
    }
    else Console.WriteLine("There are only seven days in a week");
    }


Console.WriteLine("Input number of day ");
int numDay = Convert.ToInt32(Console.ReadLine());
Week(numDay);
*/