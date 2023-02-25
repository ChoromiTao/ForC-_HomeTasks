// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int SummNonRarity = 0;

int[] GetArray()
{
    int[] array = new int[20];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-1000, 1000);
    return array;
}

int SumNonRarity(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            SummNonRarity += array[i];
        }
    }
    return SummNonRarity;
}

void PrintResult(int[] array, int SummNonRarity)
{
    Console.WriteLine($"Array result is {String.Join("|", array)}");
    Console.WriteLine($"Summary numbers of nonparitly indexes: {SummNonRarity}");
}

int[] array = GetArray();
SumNonRarity(array);
PrintResult(array, SummNonRarity);