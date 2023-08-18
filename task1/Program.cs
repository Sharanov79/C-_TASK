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

