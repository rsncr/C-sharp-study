Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int remaining = a % b;

if(remaining == 0)
{
    Console.WriteLine("Число 1 является кратным числу 2");
}
else
{
    Console.WriteLine("Число 1 НЕ является кратным числу 2");
    Console.WriteLine($"Остаток от деления:{remaining}");
}