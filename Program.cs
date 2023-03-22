// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
double[,] FillMatrixWithRandom(int row, int column)
{
    double[,] array = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++) // array.GetLength(0) - строка row
    {
        for (int j = 0; j < array.GetLength(1); j++) // array.GetLength(1) - столбец column
        { array[i, j] = Math.Round(rnd.NextDouble() * 100, 3); } 
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { Console.Write($"{array[i, j]} \t"); } // \t - интервал tab
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
*/



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// вводим число 17 для поиска или пользователь вводит индекс и определяем есть ли такой в массиве

/*
int[,] FillMatrixWithRandom(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { array[i, j] = rnd.Next(min, max + 1); }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { Console.Write($"{array[i, j]} \t"); }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите начальное значение диапазона случайного числа: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение диапазона случайного числа: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixWithRandom(row, column, min, max);
PrintMatrix(matrix);
Console.WriteLine();

// поиск по значению элемента
Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());

void FindNumberYes(int[,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"Число {number} находится на позиции [{i + 1},{j + 1}] ");
                // +1 для визуального удобства пользователя: он не знает, что индексы начинаются с нуля
                count++;
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine($"Такого числа нет");
    }
}

FindNumberYes(matrix, number);
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


/*
int[,] FillMatrixWithRandom(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { array[i, j] = rnd.Next(min, max + 1); }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { Console.Write($"{array[i, j]} \t"); }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите начальное значение диапазона случайного числа: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение диапазона случайного числа: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixWithRandom(row, column, min, max);
PrintMatrix(matrix);

void AverageColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            {
                sum = sum + array[i, j];
            }
        }
        Console.WriteLine($"Среднее арифметическое столбца {j} равно {Math.Round(sum/row, 2)}");
    }
}
AverageColumn(matrix);
*/
