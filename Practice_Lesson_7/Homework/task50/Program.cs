// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Задайте двумерный массив размером m x n");
Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix [i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j]+ " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите индекс строки:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца:");
int b = Convert.ToInt32(Console.ReadLine());

if (a >= m || b>=n) Console.WriteLine("Такого элемента нет");
else Console.WriteLine(matrix[a,b]);
