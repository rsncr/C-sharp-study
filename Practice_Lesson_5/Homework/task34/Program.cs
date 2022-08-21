// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте количество элементов одномерного массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int[l];

Console.WriteLine($"Массив из {l} элементов, заполненный положительными трехзначными числами:");

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');

int j = 0;
for(int ii = 0; ii < array.Length; ii++)
{
    if(array[ii] % 2 == 0)
    {
        j++;
    }
}
Console.WriteLine($"Количество четных элементов данного массива: {j}");