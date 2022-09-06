// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

int count = 0;

for (int k = 1; k < 10; k++)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (arr[i, j] == k) count += 1;
        }
    }
    if (count > 0)
    {
    Console.WriteLine($"{k} appears {count} times ");
    Console.WriteLine();
    count = 0;
    }
}
