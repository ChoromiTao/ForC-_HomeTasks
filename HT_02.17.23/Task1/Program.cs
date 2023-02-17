// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
char[] arr = num.ToString().ToCharArray(); 


if (num / 10000 == 0 || num / 10000 > 9)
    Console.WriteLine("Неправильно введено число!");
else
    Polindrom(arr);

void Polindrom(char[] array) 
{

    if(array[0] == array[4] && array[1] == array[3])
            System.Console.WriteLine("Это палиндром");
    else
            System.Console.WriteLine("Это не палиндром");
    }