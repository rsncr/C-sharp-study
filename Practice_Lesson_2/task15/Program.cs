Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b * b || b == a * a)
{
   Console.WriteLine("Число является квадратом второго");
}
else
{
    Console.WriteLine("Число не является квадратом второго"); 
}