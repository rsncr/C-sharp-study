string[,] table = new string [2,5];
table [1,2] = "слово";

// Индексы как для строк так и для столбцов начинаются с 0, 
// т.е. заданная таблица будет выглядеть следующим образом:

// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]
// String.Empty 

// for (int rows = 0; rows < 2 ; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.Write($"-{table[rows,columns]}-");
//     }
//     Console.WriteLine();
// }

void PrintArray(int[,] matrix )
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows,columns]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matr = new int[5,6];
PrintArray(matr);
Console.WriteLine();
FillArray(matr);
PrintArray(matr);