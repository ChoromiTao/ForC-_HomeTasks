// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = GetArray();

double[] GetArray()
{
    double[] array = new double[20];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
    return array;
}

void MaxAndMin(double[] array, double Max, double Min)
{
    double a = 0;
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

double Subtraction(double[] array, double Max, double Min)
{
    double Substrctn = Max - Min;
    return Substrctn;
}


void PrintResult(double[] array, double Max, double Min, double Substrctn)
{
    Console.WriteLine($"Array result is {String.Join("|", array)}");
    Console.WriteLine($"Maximal number: {Max}, and minimal number: {Min}");
    Console.WriteLine($"Result substraction of Max and Min: {Substrctn}");
}

MaxAndMin(array);
PrintResult(array, Subtraction());