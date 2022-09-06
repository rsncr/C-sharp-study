// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 

Console.WriteLine("Enter number of lines - m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns - n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = new Random().Next(1, 10);
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine("");
}
Console.WriteLine("");

int[,] arr2 = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr2[i, j] = arr[j, i];
        Console.Write($"{arr2[i, j]} ");
    }
    Console.WriteLine("");
}
Console.WriteLine("");