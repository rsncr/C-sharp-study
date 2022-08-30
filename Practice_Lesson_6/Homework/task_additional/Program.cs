// Дополнительная задача на рекурсию
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int Factorial (int n)
{
    if (n == 1) return n;
    else return Factorial (n-1) * n;
}
Console.WriteLine(Factorial(n));