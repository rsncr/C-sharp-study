int[] point = new int[2];
Console.WriteLine("Введите координату x: ");
point[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
point[1] = Convert.ToInt32(Console.ReadLine());

if(point[0] > 0 && point[1] > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if(point[0] > 0 && point[1] < 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if(point[0]<0 && point[1]<0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else if(point[0]<0 && point[1]>0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}
else
{
    Console.WriteLine("Точка лежит на оси");
}