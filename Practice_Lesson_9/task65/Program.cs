

Console.WriteLine("Enter value N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value M:");
int m = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int n, int m)
{
    if (n == m-1)
    {
        return;
    }
    PrintNumbers(n - 1, m);
    Console.Write($"{n} ");
}
if (m < n)
{
    Console.WriteLine("Numbers array from M to N: ");
    PrintNumbers(n, m);
}
else
{
    Console.WriteLine("Numbers array from N to M: ");
    PrintNumbers(m, n);
}