// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

System.Console.WriteLine("Input minimal number: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal number: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}
System.Console.WriteLine(Ackermann(m,n));