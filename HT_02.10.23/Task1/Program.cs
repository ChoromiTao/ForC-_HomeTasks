// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ведите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int maxx = 0;
int minn = 0;

if (a<b)
{
    maxx = b;
    minn = a;
}
else
{
    maxx = a;
    minn = b;
}
Console.WriteLine("Минимальное число " + minn + " максимальное число " + maxx);