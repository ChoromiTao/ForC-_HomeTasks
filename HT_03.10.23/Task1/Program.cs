// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


System.Console.WriteLine("Input minimal number: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal number: ");
int N = Convert.ToInt32(Console.ReadLine());


int SumNumbers(int M, int N)
{
    if (N == M) return N;
    return M + SumNumbers(M+1, N);
}

System.Console.WriteLine(SumNumbers(M,N));