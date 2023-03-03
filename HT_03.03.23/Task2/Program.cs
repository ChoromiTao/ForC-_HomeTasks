// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] array = new double[new Random().Next(5,10), new Random().Next(5,10)];
double number;
Random rnd = new Random();

double[,] GetArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            number = new Random().NextDouble();
            array[i, j] = number* new Random().Next(10,100);
            Console.Write($"{array[i, j]:F3}" + "   ");
        }
    }
    Console.WriteLine();
    return array;
}

double ArithmeticMean(double[,] array)          // Тебе нужно доделать массив в массиве с арифметическими суммами! тебе нужны среднеарифметические в каждом столбце и запомнить их!
{
    double[] ArrayArithmeticMean = new double[array.GetLength(0)];
    double ArithSum = 0;
    double ArithDev = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            ArrayArithmeticMean[i] += array[i,j];
        }
        Console.Write($"{ArrayArithmeticMean[i]:F3}" + "    ");
        ArithSum += ArrayArithmeticMean[i];

        Console.WriteLine($"The summary of column {i+1}: {ArithSum:F3}");
    }
    Console.WriteLine(" ");
    ArithDev = ArithSum / array.GetLength(1);
    Console.WriteLine();
    Console.WriteLine($"{ArithDev:F3}");
    return ArithDev;
}

GetArray(array);
ArithmeticMean(array);