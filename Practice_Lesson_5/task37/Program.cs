// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Задайте количество элементов одномерного массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int[l];

Console.WriteLine("Массив из заданного количества элементов элементов, заполненный случайными числами от -9 до 9:");

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
int l1 = 0;
int[] arr2 = new int[0];
if(array.Length % 2 == 0)
{
    l1=l/2;
    arr2 = new int[l/2];
}
else
{
    l1 = l/2+1;
    arr2 = new int[l/2+1];
}
Console.WriteLine("");
for(int j = 0; j < l1; j++)
{
    arr2[j] = array[j] * array[l-1];
    l--;
}
if(array.Length % 2 > 0)
{
    arr2[arr2.Length - 1] = array[array.Length/2];
}
Console.WriteLine("Массив произведения пар чисел: ");
Console.WriteLine('[' + string.Join(", ", arr2) + ']');

