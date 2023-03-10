// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int a = new Random().Next(2,9);
int b = new Random().Next(2,9);
int c = new Random().Next(2,9);
int[,] firstMatrix = new int[a,b];
int[,] secondMatrix = new int[b,c];

int[,] GetMatrix(int[,] array)
{
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

// int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix, int a, int c)
// {
//     int multiFunction;
//     int multiplic;
//     int[,] multiplicationMatrix = new int[a,c];
// for (int i = 0; i < multiplicationMatrix.GetLength(0); i++)
// {
//     Console.WriteLine();
//     for (int j = 0; j < multiplicationMatrix.GetLength(1); j++)
//     {
//         for (int i = 0; i < length; i++)
    //         {
                
    //         }
//         multiplic = 
//         multiFunction = 
//         multiplicationMatrix[i,j] = multiFunction;
//         Console.Write($"{multiplicationMatrix[i,j]}" + "   ");
//     }
// }
// return multiplicationMatrix;
// }

Console.WriteLine("The first matrix is: ");
firstMatrix = GetMatrix(firstMatrix);
Console.WriteLine("The second matrix is: ");
secondMatrix = GetMatrix(secondMatrix);