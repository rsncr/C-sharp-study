﻿// Задача 51:Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



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
Console.WriteLine();

double res = 0;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            res = res + matrix[i, j];
        }
    }
}
Console.WriteLine($"Сумма элементов массива по главной диагонали = {res}");