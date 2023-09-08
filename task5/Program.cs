/*
Задача 31. 
Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
*/

Console.Clear();
int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for (int i=0;i<size;i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array = GetArray(12, -9, 9);
Console.WriteLine();
int[] array1 = GetArray(5, 2, 5);
int positiveSum=0;
int negativeSum=0;
Console.WriteLine();
foreach (int i in array)
{
    if(i>0)
        positiveSum += i;
    else
        negativeSum += i;
    
}
Console.WriteLine();
Console.WriteLine($"Сумма положительный чисел ={positiveSum}, Сумма отрицательных чисел ={negativeSum}");


/*
Задача 32.
Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

Console.Clear();
int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for (int i=0;i<size;i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array = GetArray(12, -9, 9);
Console.WriteLine();
int[] array1 = new int[array.Length];
int j = 0;
foreach (int i in array)
{
    
    if (i > 0)
    {
        array1[j] = i * -1;
        j++;
    }    
    else
    {
        array1[j] = i * -1;
        j++;
    }    
    Console.Write(array1[j-1]);
}


/*
Задача 33.
Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] arr = new int[20];

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(100);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}    
 void IsNumArray(int[] array, int num)
{
    int numExist = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        numExist += arr[i] == num ? 1 : 0;
    }
    if (numExist > 0)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
RandomArray(arr);
IsNumArray(arr, num);

/*
Задача 35. 
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

Console.Clear();

int[] arr = new int[123];

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(1000);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}    
 void IsNumArray(int[] array)
{
    int numExist = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr[i] < 99)
        {
            numExist++;
        }
    }
    if (numExist > 0)
    {
        Console.WriteLine($"Количество чисел - {numExist}");
    }
    else
    {
        Console.WriteLine($"Чисел нет - {numExist}");
    }
}
RandomArray(arr);
IsNumArray(arr);

