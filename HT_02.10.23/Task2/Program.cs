// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Здравстуйте. Эта программа поможет Вам определить максимальное и минимальное число из трёх проедложенных чисел");

Console.WriteLine("Ведите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int maxx = a;

if(b>maxx)
{
    maxx = b;
}
else
{
    if(c>maxx)
    {
        maxx = c;
    }
}
Console.WriteLine("Максимальное из предложенных чисел " + maxx);