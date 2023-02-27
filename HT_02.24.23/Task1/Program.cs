// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int count = 0;

int[] GetArray()         //для создания рандомного массива на рандомное количество 
{
    int[] array = new int[new Random().Next(15, 20)];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

// int[] InputArray()               // для введения вручную рандомного массива, но почему-то консоль начинает зависать при использовании этой функции - на одном и том же месте
// {
//     Console.WriteLine("Input number of quantity array elements: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[a];
//     Console.WriteLine("Input three-digit array elements, which greater zero: ");
//         for (int i = 0; i < a; i++)
//         {
//             int el = Convert.ToInt32(Console.ReadLine());
//             while (el>99 && el<1000)
//                 array[i] = el;
//         } 
//     return array;
// }

int Parity(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
            count +=1;
    }
    return count; 
}

void PrintResult(int[] array, int count)
{
    Console.WriteLine($"Array result is {String.Join("|", array)}");
    Console.WriteLine($"Quantity of paritly numbers: {count}");
}

int[] array = GetArray();
Parity(array);
PrintResult(array, count);