// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Enter value N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value M:");
int m = Convert.ToInt32(Console.ReadLine());

int Sum(int n, int m)
{
    if (n == m - 1)
    {
        return 0;
    }
    return n + Sum(n - 1, m);
}
if (m < n)
{
    Console.WriteLine($"Sum of numbers from M to N: {Sum(n, m)}");
}
else
{
    Console.WriteLine($"Sum of numbers from M to N: {Sum(m, n)}");
}