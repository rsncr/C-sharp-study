// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами от -9 до 9
// Напишите программу, которая находит сумму положительных и отрицательных элементов массива

int[] array = new int[12];

Console.WriteLine("Массив из 12 элементов, заполненный случайными числами от -9 до 9:");

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);
    Console.Write($"{array[i]} ");
}
int sumneg = 0;
int sumpos = 0;
Console.WriteLine("");
Console.Write("Положительные элементы массива: ");
for (int ii = 0; ii < array.Length; ii++)
{
    if (array[ii] > 0)
    {
        sumpos = sumpos + array[ii];
        Console.Write($"{array[ii]} ");
    }
}
Console.WriteLine("");
Console.Write("Отрицательные элементы массива: ");
for (int ii = 0; ii < array.Length; ii++)
{
    if (array[ii] < 0)
    {
        sumneg = sumneg + array[ii];
        Console.Write($"{array[ii]} ");
    }
}
Console.WriteLine("");
Console.WriteLine($"Сумма положительных элементов массива = {sumpos}");
Console.WriteLine($"Сумма отрицательных элементов массива = {sumneg}");