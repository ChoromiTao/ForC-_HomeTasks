// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Здравствуйте, эта программа поможет Вам найти все чётные числа, до указанного Вами числа");
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if(a<0)
{
    for (int b = a; b <= Math.Abs(a); b++)
    {
        if(b%2 == 0 && b != 0)
        {Console.WriteLine(b);}
    }
}
else
{
    for (int b = 0; b <= a; b++)
    {
        if(b%2 == 0 && b != 0)
        {Console.WriteLine(b);}
    }
}

Console.WriteLine("Определение закончено!");