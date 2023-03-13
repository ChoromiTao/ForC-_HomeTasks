// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int size = new Random().Next(2, 6);

int[,,] GetArray(int size)
{
    int[,,] array = new int[size, size, size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < size; j++)
        {
            Console.WriteLine();
            for (int k = 0; k < size; k++)
            {
                int num;
                do
                {
                    num = new Random().Next(10, 100);
                } 
                while (UniqeNumber(array, size, num));
                array[i, j, k] = num;
                Console.Write($"{array[i, j, k]}({i},{j},{k})" + "   ");
            }
        }
    }
    Console.WriteLine("\n");
    return array;
}

static bool UniqeNumber(int[,,] array, int size, int num)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                if (array[i, j, k] == num)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

int[,,] array = GetArray(size);