/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

void OrderMatrix(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }

        }

    }
}

Console.WriteLine("Original matrix: ");
CreateMatrix(arr);
PrintMatrix(arr);

Console.WriteLine("Sorted matrix: ");
OrderMatrix(arr);
PrintMatrix(arr);