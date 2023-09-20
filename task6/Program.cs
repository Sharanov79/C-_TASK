/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

Console.Clear();

int[] array = GetArray(10,0,10);
Console.WriteLine(String.Join(" ", array));
int[] reversArray = ReversArray(array);
Console.WriteLine(String.Join(" ", reversArray));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue);
    }
    return res;
}
int[] ReversArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for(int i = 0; i<inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length -1 -i];
        
    }
    return result;
}


/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

Console.Clear();

int a,b,c;
Console.WriteLine("Введите длину стороны a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны c: ");
c = Convert.ToInt32(Console.ReadLine());
string result;
result = Result (a,b,c);
Console.WriteLine (result);

string Result (int a,int b,int c)
{
    string result = string.Empty;
    if (a<(b+c) && b<(a+c) && c<(a+b))
    {
        result = "Такой треугольник имеет право на жизнь.";

    }
    else 
    {
        result = "Отрезки не сложаться в треугольник";
    }
    return result;
}


/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 
*/
//Вариант 1

Console.Clear();
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int number = userNumber;
int remains = 0;

while(number > 0)
{
    remains = number % 2;
    Console.Write(remains);
    number = number / 2;
    
}

// вариант 2 (рекурсия)

Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int TenToTwo(int number)
{
    if (number == 1) return 1;
    if (number == 0) return 0;
    return number % 2 + 10 * TenToTwo(number /2);
}
Console.WriteLine(TenToTwo(a));


/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] Fib(int size)
{
    int[] arr = new int[size];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < size; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}
int[] Array = Fib(num);
PrintArray(Array);


/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

Console.Clear();
int[] arr = new int[8];
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
RandomArray(arr);

Console.WriteLine();

void CopiedArray(int[] arr)
{
    int[] copiedArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copiedArr[i] = arr[i];
        Console.Write($"{copiedArr[i]} ");
    }
}
CopiedArray(arr);

