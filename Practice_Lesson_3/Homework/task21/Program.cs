//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double[] p1 = new double[3];
Console.WriteLine("Введите координату x точки 1: ");
p1[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки 1: ");
p1[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z точки 1: ");
p1[2] = Convert.ToDouble(Console.ReadLine());

double[] p2 = new double[3];
Console.WriteLine("Введите координату x точки 2: ");
p2[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки 2: ");
p2[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z точки 2: ");
p2[2] = Convert.ToDouble(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(p2[0]-p1[0], 2)+Math.Pow(p2[1]-p1[1], 2)+Math.Pow(p2[2]-p1[2], 2));

Console.WriteLine($"Расстояние между точками = {d}");