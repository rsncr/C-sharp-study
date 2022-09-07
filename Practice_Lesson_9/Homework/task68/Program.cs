﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> Akk(m,n) = 29

Console.WriteLine("Enter value M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value N:");
int n = Convert.ToInt32(Console.ReadLine());

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akk(m - 1, 1);
    else return Akk(m - 1, Akk(m, n - 1));
}
Console.WriteLine(Akk(m, n));