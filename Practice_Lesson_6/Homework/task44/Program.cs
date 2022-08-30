// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8




Console.WriteLine("Введите количество чисел Фибоначчи для вывода:");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int [m];
array[0] = 0;

if (m == 1) Console.WriteLine($"[{array[0]}]");
else
{
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    Console.WriteLine('[' + string.Join(", ", array) + ']');
}