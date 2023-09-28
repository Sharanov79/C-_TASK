/*
Задача 53.
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
*/

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int raws = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[raws, colums];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 20);
        }
    }
}

int[,] ChangeArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(0) -1, j];
        array[array.GetLength(0)-1,j] = temp;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);

Console.WriteLine();

ChangeArray(array);
PrintArray(array);


/*
Задача 55.
Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int raws = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[raws, colums];


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 20);
        }
    }
}

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

ChangeArray(array);
PrintArray(array);


/*
Задача 57.
Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.

Набор данных                      Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }         0 встречается 2 раза
                                   1 встречается 1 раз
                                   2 встречается 1 раз
                                   8 встречается 1 раз
                                   9 встречается 3 раза

1, 2, 3                           1 встречается 3 раза
                                  2 встречается 2 раз
                                   3 встречается 1 раз
                                  4 встречается 1 раз
                                  6 встречается 2 раза
4, 6, 1
2, 1, 6                                  

*/

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int raws = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[raws, colums];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 20);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int[] GetRowArray(int[,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[count] = array[i,j];
            count++;
        }
    }
    return result;
}

void SortArray(int[] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = 1; j < result.Length; j++ )
        {
            if (result[i] > result[j])
            {
                int temp = result[i];
                result[i] = result[j];
                result[j] = temp;
            }
        }
    }
}

void PrintData(int[] result)
{
    int count = 1;
    int firstNumber = result[0];
    for (int i = 1; i < result.Length; i++)
    {
        if (result[i] != firstNumber)
        {
            Console.WriteLine($"{firstNumber} встречается {count} раз. ");
            firstNumber = result[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{firstNumber} встречается {count} раз. ");
}

FillArray(array);
PrintArray(array);
int[] result = GetRowArray(array);
Console.WriteLine();
SortArray(result);
PrintData(result);


/*
Задача 59.
Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/

int [,] FillArray(int rowNumber, int columnNumber)
{
    int[,] result = new int[rowNumber, columnNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < columnNumber; j++)
        {
            result[i,j] = new Random().Next(1, 20);
            Console.Write($"{result[i,j]} \t");
        }
        Console.WriteLine();
    }
    return result;
}

int [] FindMinNumber(int[,] array)
{
    int[] result = new int[2];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < min)
            min = array[i, j];
            result[0] = i;
            result[1] = j;
        }
        
    }
    return result;
}

void PrintArray(int [,] array, int [] minCoordinates)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            if (i != minCoordinates[0] || j != minCoordinates[1]);
            {
                Console.Write($"{array[i,j]} \t");
            }
        }
    }
}

int rowNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int columnNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();
int [,] array = FillArray(rowNumber, columnNumber);
int minCoordinates = FindMinNumber(array);
PrintArray(array, minCoordinates);
