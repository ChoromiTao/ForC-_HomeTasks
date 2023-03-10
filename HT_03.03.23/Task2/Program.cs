// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] array = new double[new Random().Next(5,10), new Random().Next(5,10)];

double[,] GetArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble()* new Random().Next(10,100);
            Console.Write($"{array[i, j]:F3}" + "   ");
        }
    }
    Console.WriteLine();
    return array;
}

void ArithmeticMean(double[,] array)          
{
    double[] ArrayArithmeticMean = new double[array.GetLength(0)];
    double ArithDev = 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            ArrayArithmeticMean[j] += array[i,j];
        }
        Console.Write($"A summary of elements in column {j+1}: {ArrayArithmeticMean[j]:F3}" + "    ");
        ArithDev = ArrayArithmeticMean[j] / array.GetLength(0);
        Console.WriteLine($"The Arithmethic mean of column {j+1}: {ArithDev:F3}");
    }
    Console.WriteLine("\n");
}

array = GetArray();
ArithmeticMean(array);