// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string b = Convert.ToString(a);
int sum = 0;

for (int i = 0; i < b.Length; i++)
{
    int digit = a % 10;
    a = a / 10;
    sum = sum + digit;
}
Console.WriteLine($"Сумма цифр числа = {sum}");