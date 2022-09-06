/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int m = 2;
int n = 2;
int o = 2;

int[,,] arr = new int[m, n, o];

void Create3DArray(int[,,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < o; k++)
            {
                arr[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < o; k++)
            {
                Console.Write($"{arr[i, j, k]} {(i, j, k)} ");
            }
            Console.WriteLine("");
        }

    }
}
Console.WriteLine("3D Array with indexes: ")
Create3DArray(arr);
Print3DArray(arr);