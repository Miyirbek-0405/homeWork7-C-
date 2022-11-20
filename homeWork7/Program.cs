
// ==================================== start ==================================================

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
double[,] RandomDimArray()
{
    Console.Write("Введите размер массива строка: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите размер массива столбец: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите min число массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите max число массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    double[,] dimArray = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            dimArray[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);
        }
    }
    return dimArray;
}
void CreateDimArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 1)}  ");
        }
        Console.WriteLine();
    }
}

double[,] randDimArray = RandomDimArray();
CreateDimArray(randDimArray);
*/

// ==================================== end ==================================================

// ==================================== start ==================================================

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*
int[,] CreateDimArray()
{
    Console.Write("Введите размер массива строка: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите размер массива столбец: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите min число массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите max число массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] createArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            createArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return createArray;
}

void PrintDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

string PositionDimArray(int[,] array)
{
    Console.Write("Введите индексI массива: ");
    int indexI = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индексJ массива: ");
    int indexJ = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == indexI & j == indexJ)
            {
                return $"нашли элемент это - {array[i, j]}";
            }
        }
    }
    return $"{indexI}, {indexJ} -> такого числа в массиве нет";
}

int[,] dimArray = CreateDimArray();
PrintDimArray(dimArray);
string resultElement = PositionDimArray(dimArray);
Console.WriteLine(resultElement);
*/

// ==================================== end ==================================================

// ==================================== start ==================================================

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateDimArray()
{
    Console.Write("Введите размер массива строка: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите размер массива столбец: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите min число массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите max число массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] createArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            createArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return createArray;
}

void PrintDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] SredArifArray(int[,] array)
{
    double[] sredArr = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        sredArr[i] = sum / array.GetLength(0);
    }
    return sredArr;
}

void PrintNewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 1)}  ");
    }
    Console.WriteLine();
}

int[,] oldDimArray = CreateDimArray();
PrintDimArray(oldDimArray);
double[] newArray = SredArifArray(oldDimArray);
PrintNewArray(newArray);


// ==================================== end ==================================================