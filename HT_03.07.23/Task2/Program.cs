// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GetArray()
{
    int[,] array = new int[new Random().Next(3,6), new Random().Next(3,6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write($"{array[i,j]}" + "   ");
        }
    }
    Console.WriteLine("\n");
    return array;
}

int[] Summary(int[,] array)          
{
    int[] arraySummary = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arraySummary[i] += array[i,j];
        }
    }
    return arraySummary;
}

void Compairison(int[] arraySummary)
{
    int minimalSummarise = arraySummary[0];
    int minimalIndex = 0;
    for (int i = 0; i < arraySummary.Length; i++)
    {
        if(minimalSummarise>arraySummary[i])
            {
                minimalSummarise = arraySummary[i];
                minimalIndex = i;
            }
    }
    System.Console.WriteLine($"The string with minimal summary: {minimalIndex + 1} string");
}

int[,] array = GetArray();
Compairison(Summary(array));