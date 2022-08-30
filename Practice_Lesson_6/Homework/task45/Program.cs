// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

Console.WriteLine("Задайте количество элементов одномерного массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] arr1 = new int[l];

Console.WriteLine("Массив из заданного количества элементов, заполненный случайными числами от -9 до 9:");

for(int i = 0; i < arr1.Length; i++)
{
    arr1[i] = new Random().Next(-9,10);
}
Console.WriteLine('[' + string.Join(", ", arr1) + ']');

int[] arr2 = new int[l];
for (int i = 0; i < arr2.Length; i++)
{
    arr2[i]=arr1[i];
}
Console.WriteLine("Копия вышеуказанного массива:");
Console.WriteLine('[' + string.Join(", ", arr2) + ']');