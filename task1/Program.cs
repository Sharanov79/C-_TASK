/* 
Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/
int usernumber = new int();
Console.WriteLine("Введите число ");
usernumber = Convert.ToInt32(Console.ReadLine());

int result = (usernumber * usernumber);

Console.WriteLine($"Степень числа {usernumber} = {result}");

/* 
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Например:
a = 5, b = 25 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> нет 
a = -3 b = 9 -> да
*/

    Console.WriteLine("Введите число 1: ");
    int userNumber1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число 2: ");
    int userNumber2 = Convert.ToInt32(Console.ReadLine());

    if(userNumber2 == userNumber1*userNumber1){
        Console.WriteLine("true");
    }else{
        Console.WriteLine("false");
    }


/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру. 
Например:
3 -> Среда 5 -> Пятница
*/

Console.WriteLine("Введите число ");
int day = Convert.ToInt32(Console.ReadLine());
if(day <=0 || day>7) Console.WriteLine("Неправильное число число ");
else if(day == 1) Console.WriteLine("Понедельник ");
else if(day == 2) Console.WriteLine("Вторник ");
else if(day == 3) Console.WriteLine("Среда ");
else if(day == 4) Console.WriteLine("Четверг ");
else if(day == 5) Console.WriteLine("Пятница ");
else if(day == 6) Console.WriteLine("Суббота ");
else if(day == 7) Console.WriteLine("Воскресенье ");

/* Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 
Например:
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"
*/

 
int number = Convert.ToInt32(Console.ReadLine());
for(int i = -number; i<=number; i++)
{
    Console.Write(i);
}

/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 
Например:
456 -> 6 782 -> 2 918 -> 8
*/
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number%10;
Console.WriteLine(number2);



