// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество вводимых чисел:");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int [m];
int j = 0;

for (int i = 1; i <= array.Length; i++)
{
    Console.WriteLine($"Введите число {i}:");
    array[i-1] = Convert.ToInt32(Console.ReadLine());
    if (array[i-1] > 0) j++;
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Количество чисел больше нуля = {j}");