// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте количество элементов одномерного массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int[l];

Console.WriteLine($"Массив из {l} элементов, заполненный числами от -10 до 10:");

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,11);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');

int sum = 0;

for(int ii = 1; ii < array.Length; ii = ii+2)
{
    sum = sum + array[ii];   
}

Console.WriteLine($"Сумма элементов, с нечетными индексами в массиве: {sum}");