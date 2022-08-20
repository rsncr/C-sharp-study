// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 0)
{
    Console.WriteLine("Ошибка! Количество элементов массива должно быть целым числом > 0");
}
else
{
int[] array = new int[a];
Console.Write("Изначальный массив: "); 
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,9);
    Console.Write($"{array[i]} ");
}

int Factorial(int n)
{
    if (n == 1) return 1;
 
    return n * Factorial(n - 1);
}

Console.WriteLine("");
Console.Write("Производный массив: ");

for (int ii = 0; ii < array.Length; ii++)
{
    int fac = Factorial(array[ii]);
    Console.Write($"{fac} ");
}
}