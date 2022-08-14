﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N>0)
{
    int count = 1;
    while(count <= N)
        {
            Console.Write($"{Math.Pow(count, 3)} ");
            count++;
        }
}
if(N<0)
{
    int count = -1;
    while(count >= N)
        {
            Console.Write($"{Math.Pow(count, 3)} ");
            count--;
        }
}
else
{
    Console.WriteLine("N должно быть целым числом отличным от нуля");
}
