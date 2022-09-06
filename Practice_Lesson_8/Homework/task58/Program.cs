/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.WriteLine("Enter number of lines of matrix 1 (same number columns of matrix 2) - m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns of matrix 1 (same number for lines of matrix 2) - n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
int[,] arr2 = new int[n, m];
int[,] product = new int[m, m];

void CreateMatrix(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(1, 6);
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

void MatrixProduct(int[,] arr, int[,] arr2, int[,] product)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int k = 0; k < m; k++)
            {
                sum += arr[i, k] * arr2[k, j];
            }
            product[i, j] = sum;
        }
    }
}

Console.WriteLine("Matrix 1: ");
CreateMatrix(arr);
PrintMatrix(arr);

Console.WriteLine("Matrix 2: ");
CreateMatrix(arr2);
PrintMatrix(arr2);

Console.WriteLine("Matrix Product: ");
MatrixProduct(arr, arr2, product);
PrintMatrix(product);