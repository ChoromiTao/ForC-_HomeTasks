int[,] SpiralMassive(int size)
{
    int[,] array = new int[size, size];
    int value = 1;
    int row = 0;
    int col = 0;

    while (value <= size * size)
    {
        // fill top row from left to right
        for (int i = col; i < size - col; i++)
        {
            array[row, i] = value++;
        }
        row++;

        // fill right column from top to bottom
        for (int i = row; i < size - row + 1; i++)
        {
            array[i, size - col - 1] = value++;
        }
        col++;

        // fill bottom row from right to left
        for (int i = size - col - 1; i >= col - 1; i--)
        {
            array[size - row, i] = value++;
        }

        // fill left column from bottom to top
        for (int i = size - row - 1; i >= row; i--)
        {
            array[i, col - 1] = value++;
        }
    }

    return array;
}

int size = 0;
void InputNumber(ref int size)
{
    System.Console.WriteLine("Input a number of rows and coloumns: ");
    size = Convert.ToInt32(Console.ReadLine());
    if (size <= 0)
    {
        Console.WriteLine("Invalid input. Size must be a positive integer.");
        return;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
    }
}

InputNumber(ref size);
int[,] array = SpiralMassive(size);
PrintArray(array);