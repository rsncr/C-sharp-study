// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine("Задайте двумерный массив размером m x n");
Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
double[] avg = new double[n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        avg[j] += matrix[i, j] / m;
    }
    Console.WriteLine();

}
Console.WriteLine("Среднее арифметическое элементов каждого столбца матрицы:");
Console.WriteLine('[' + string.Join(", ", avg) + ']');



