double[] point1 = new double[2];
Console.WriteLine("Введите координату x точки 1: ");
point1[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки 1: ");
point1[1] = Convert.ToDouble(Console.ReadLine());

double[] point2 = new double[2];
Console.WriteLine("Введите координату x точки 2: ");
point2[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки 2: ");
point2[1] = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Расстояние между точками = {Math.Sqrt((point2[1]-point1[1])*(point2[1]-point1[1])+(point2[0]-point1[0])*(point2[0]-point1[0]))}");

Console.WriteLine($"Расстояние между точками = {Math.Sqrt(Math.Pow(point2[1]-point1[1], 2)+Math.Pow(point2[0]-point1[0], 2))}");