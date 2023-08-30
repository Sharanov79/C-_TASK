/*
 Задача 1.
 Напишите программу, которая принимает на вход координаты точки (X и Y), 
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

int getQuoterFromCoordinate(int x, int y)
{
    int result = 0;
    if(x > 0 && y > 0)
    {
        result = 1;
    }
    else if(x < 0 && y > 0)
    {
        result = 2;
    }
    else if(x < 0 && y < 0)
    {
        result = 3;
    }
    else if(x > 0 && y < 0)
    {
        result = 4;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"X и Y не должны быть ровны 0 вы ввели {x} {y}");
        Console.ResetColor();
    }  
    return result;
}
int userX = 0;
int userY = 0;

Console.WriteLine("Введите X:");
userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y:");
userY = Convert.ToInt32(Console.ReadLine());
int quoter = getQuoterFromCoordinate(userX,userY);
Console.WriteLine($"Для координаты {userX}:{userY} находятся в {quoter} четверти" );

/*
Задача 2.
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

Console.WriteLine("Введите номер четверти от 1 до 4: ");
int quoterNumber = Convert.ToInt32(Console.ReadLine());

if (quoterNumber == 1)
{
    Console.WriteLine("Диапазон возможных значений X и Y в 1 четверти: от 0 до бесконечности");
}
else if (quoterNumber == 2)
{
    Console.WriteLine("Диапазон возможных значений в 2 четверти: X до 0 до минус бесконечности, Y от 0 до бесконечности ");
}
else if (quoterNumber == 3)
{
    Console.WriteLine("Диапазон возможных значений в 3 четверти: X до 0 до минус бесконечности, Y от 0 до минус бесконечности ");
}
else if (quoterNumber == 3)
{
    Console.WriteLine("Диапазон возможных значений в 4 четверти: X до 0 до бесконечности, Y от 0 до минус бесконечности ");
}
else
{
    Console.WriteLine("Четверть должна быть равна от 1 до 4");
}

/*
Задача 3.
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. 
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координаты точки A: ");
double dotAx = Convert.ToDouble(Console.ReadLine());
double dotAy = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
double dotBx = Convert.ToDouble(Console.ReadLine());
double dotBy = Convert.ToDouble(Console.ReadLine());

double dotC = Math.Sqrt(Math.Pow((dotAx) - (dotBx), 2) + Math.Pow((dotAy) - (dotBy), 2));
Console.WriteLine(Math.Round(dotC, 2));

/*
Задача 4.
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. 
5 -> 1, 4, 9, 16, 25. 
2 -> 1,4
*/

Console.WriteLine("введите число N: ");
int nNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= nNumber; i++)
{
    Console.Write($" {i * i} ");
}

/*
Задача 5.
По данному натуральному числу n найдите сумму чисел 1+1/1!+1/2!+1/3!+...1/n!.
Количество действий должно быть пропорционально n.
Напишите программу, которая считывает значение n и выводит результат в виде действительного числа.
*/
Console.WriteLine("введите число N: ");
int nNumber = Convert.ToInt32(Console.ReadLine());

double f = 1;
double cNum = 1;

for (int i = 1; i <= nNumber; i++)
{
    f = f * i;
    cNum = cNum + (1 / f);
}
Console.WriteLine($"{Math.Round(cNum, 5)}");



