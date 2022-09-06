// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.


// Console.WriteLine("Enter number of lines - m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns - n:");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m, n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         arr[i, j] = new Random().Next(1, 10);
//         Console.Write($"{arr[i, j]} ");
//     }
//     Console.WriteLine("");
// }
// Console.WriteLine("");

// int[,] arr2 = new int[m, n];


// for (int k = 0; k < n; k++)
// {
//     arr2[0, k] = arr[m-1, k];
//     Console.Write($"{arr2[0, k]} ");
// }
// for (int k = 1; k < n-2; k++)
// {
//     ar r2[k, m] = arr[k, m-2];
//     Console.Write($"{arr2[k, m-2]} ");
// }
// Console.WriteLine("");

const int ROWS = 3;
const int COLUMNS = 3;

int[,] FillMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < length; j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < length; j++)
        {
            Console.WriteLine(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = FillMatrix(ROWS, COLUMNS);
PrintMatrix(matrix);