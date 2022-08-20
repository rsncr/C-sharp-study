// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

Console.WriteLine("Массив из 8 случайных чисел от 0 до максимального значения:");

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,int.MaxValue);
    Console.Write($"{array[i]} ");
}