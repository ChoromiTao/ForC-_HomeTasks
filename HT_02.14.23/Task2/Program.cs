// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
char[] arr = num.ToString().ToCharArray();
int count = 0;
Console.WriteLine();

FindNumber(arr);

void ReadArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        count = i;
        count++;
    }
}

void FindNumber(char[] array)

{
    ReadArray(arr);

    Console.WriteLine();

    if (count > 2)

         Console.WriteLine(arr[2]);

    else 

        Console.WriteLine("Третьего числа нет");

    }