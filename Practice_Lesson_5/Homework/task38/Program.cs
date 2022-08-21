// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте количество элементов одномерного массива: ");
int l = Convert.ToInt32(Console.ReadLine());
double[] array = new double[l];

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива:");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine($"Получен массив из {l} элементов, заполненный пользовательскими числами: ");
Console.WriteLine('[' + string.Join(", ", array) + ']');

double max = 0;
double min = double.MaxValue;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
}
for(int i = 0; i < array.Length; i++)
{
    if(array[i] < min)
    {
        min = array[i];
    }
}
double dif = Math.Round(max-min,3);
Console.WriteLine($"Разница между максимальным и минимальным значениями массива составляет: {dif}");

