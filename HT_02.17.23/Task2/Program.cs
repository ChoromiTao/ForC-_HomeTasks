// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки А");
double Ax = Convert.ToInt32(Console.ReadLine());
double Ay = Convert.ToInt32(Console.ReadLine());
double Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В");
double Bx = Convert.ToInt32(Console.ReadLine());
double By = Convert.ToInt32(Console.ReadLine());
double Bz = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(Bx-Ax, 2) + Math.Pow(By-Ay, 2) + Math.Pow(Bz-Az, 2));

Console.WriteLine($"Координаты A: {Ax}, {Ay}, {Az} координаты В: {Bx}, {By}, {Bz} расчёт расстояния между точками: " + result);