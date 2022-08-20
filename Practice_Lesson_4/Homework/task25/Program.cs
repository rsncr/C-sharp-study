// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -   > 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число B: ");
double b = Convert.ToDouble(Console.ReadLine());
double c = 1;

if (b > 0)
{
    for (int i = 0; i < b; i++)
    {
        c = c * a;
    }
}
else if (b < 0)
{
    for (int i = 0; i < Math.Abs(b); i++)   
    { 
        c = c * (1/a);
    }
}
else if (b == 0)
{
    c = 1;
}
Console.WriteLine($"{a} в степени {b} = {c}");