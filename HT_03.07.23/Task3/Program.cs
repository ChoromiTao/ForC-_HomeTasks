// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int a = new Random().Next(3, 9);
int b = new Random().Next(3, 9);
int c = new Random().Next(3, 9);
int[,] firstMatrix = new int[a, b];
int[,] secondMatrix = new int[b, c];

int[,] GetMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]}" + "   ");
        }
    }
    Console.WriteLine("\n");
    return array;
}

int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix, int a, int c)
{
    int[,] multiplicationMatrix = new int[a, c];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        Console.WriteLine();
        int multiplic = 0;
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            int multiFunction = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                multiplic = firstMatrix[i, k] * secondMatrix[k, j];
                multiFunction += multiplic;
            }
            multiplicationMatrix[i, j] = multiFunction;
            Console.Write($"{multiplicationMatrix[i, j]}" + "   ");
        }
    }
    return multiplicationMatrix;
}

Console.WriteLine("The first matrix is: ");
firstMatrix = GetMatrix(firstMatrix);
Console.WriteLine("The second matrix is: ");
secondMatrix = GetMatrix(secondMatrix);
MultiplicationMatrix(firstMatrix, secondMatrix, a, c);