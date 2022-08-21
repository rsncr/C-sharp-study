// Задача 32: Напишите программу замены элементов массива: положительные элементы нужно заменить
// на соответственные отрицательные и наоборот

int[] array = new int[12];

Console.WriteLine("Иcходный массив: ");

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);
    Console.Write($"{array[i]} ");
}
int convert (int n)
{
    if (n == 0) return 0;
 
    return n * -1;
}
Console.WriteLine("");
Console.Write("Производный массив: ");
Console.WriteLine("");

for (int ii = 0; ii < array.Length; ii++)
{
    int conv = convert(array[ii]);
    Console.Write($"{conv} ");
}
