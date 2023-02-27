// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = GetArray();
int Max = array[0];
int Min = array[1];
int subtraction = 0;

int[] GetArray()
{
    int[] array = new int[new Random().Next(15,25)];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
    return array;
}

void MaxAndMin(int[] array, ref int Max, ref int Min)
{
    int a = 0;
    if(Max<Min)
    {
        a = Max;
        Max = Min;
        Min = Max;
    }  
    else foreach (int el in array)
    {
        if (el > Max)
            Max = el;
        else if(el < Min)
            Min = el;
    }
}

int Subtraction(int[] array, int Max, int Min, ref int subtraction)
{
    subtraction = Max - Min;
    return subtraction;
}


void PrintResult(int[] array, int Max, int Min, int subtraction)
{
    Console.WriteLine($"Array result is {String.Join("|", array)}");
    Console.WriteLine($"Maximal number: {Max}, and minimal number: {Min}");
    Console.WriteLine($"Result substraction of Max and Min: {subtraction}");
}

MaxAndMin(array, ref Max, ref Min);
Subtraction(array, Max, Min, ref subtraction);
PrintResult(array, Max, Min, subtraction);