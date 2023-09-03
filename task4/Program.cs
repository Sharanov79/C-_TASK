/*
Задача 24.
Напишите программу, которая принимает на вход число (A) и выдает сумму чисел от 1 до A.
7 -> 28
4 -> 10
8 -> 16

Задаем число A, создаем метод возвращаемого типа, который будет выдавать сумму чисел от 1 до A.
Задаем счетчик, который будет увеличиваться, каждый проход цикла
Добавляем переменную, которая будет содержать в себе сумму
*/

Console.Clear();
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

int GetSumNums(int number)
{
    int sum = 0;
    int i = 1;
    while(i<=number)
    {
        sum +=i;
        Console.Write($"{i} ");
        i++;
    }
    return sum;
}
Console.WriteLine($"Сумма чисел от1 до A = {GetSumNums(num)}");

/*
Задача 26.
Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int count = 0; //количество цифр в числе

while (A > 0)
{
    A /= 10; // A = A/10
    count++;
}
Console.WriteLine($"Количество цифр в числе = {count}");

/*
Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.Clear();
Console.Write("Введите число: ");
int getTheMultiply(int number)
{
    int result = 1;
    for (int i = 1; i<=number; i++)
    {
        result = result * i;
    }
    return result;
}

int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Произведение чисел от 1 до {number} = {getTheMultiply(number)}");

/*
Задача 30.
Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

int [] arr = new int[8]; //создали массив из 8 элементов

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random(); // создание объекта для генерации чисел
        int value = rnd.Next(0, 2);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}
RandomArray(arr);

