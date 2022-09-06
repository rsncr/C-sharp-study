/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка */

Console.WriteLine("Enter number of lines - m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns - n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

void CreateMatrix(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine("");
    }
}

int sum = 0;
int[] arr2 = new int[m];

void MinSumLine(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum += arr[i, j];
            arr2[i] = sum;
        }
        sum = 0;
    }
    int minSumLine = Array.IndexOf(arr2, arr2.Min());
    Console.WriteLine(minSumLine+1);
}


Console.WriteLine("Original matrix: ");
CreateMatrix(arr);
PrintMatrix(arr);

Console.WriteLine("Line with minimal sum of elements: ");
MinSumLine(arr);