/*
Задача 1.
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 
Например: 78 -> 8 12-> 2 85 -> 8
*/

int GetRandomNumberInRange(int miNnumber, int maxNumber)
{
    int result = new Random().Next(miNnumber,maxNumber +1);
    return result;
}
int GetMaxDigitFromNumber(int number)

{
    int result = number / 10;
    int secondDigit = number % 10;
    if(secondDigit > result)
    {
        result = secondDigit;
    }
    return result;
}

int randomNumber = GetRandomNumberInRange(10, 99);
int maxDigit = GetMaxDigitFromNumber(randomNumber);

Console.WriteLine($"Наибольшая цифра числа {randomNumber} является {maxDigit}");

/*
Задача 2.
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
Например: 456 -> 46 782 -> 72 918 -> 98
*/

int number = new Random().Next(100, 999);

int number1 = number / 100 *10;
int number2 = number % 10;

Console.Write(number);
Console.WriteLine();
Console.Write(number1 + number2);

/*
Задача 3.
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно
*/

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine($"Не кратное: {number1 % number2}");
}

/*
Задача 4.
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 46 -> нет 161 -> да
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}
/*
Задача 5.
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да 
-4, 16 -> да 
25, 5 -> да 
8,9 -> нет
*/
void CheckMultiple(int number1, int number2)
{
    if (number2 == number1 * number1)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
Console.WriteLine("Inter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2)
{
    CheckMultiple(number1, number2);
}
else
{
    CheckMultiple(number2, number1);
}
