/* Задача 67:Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

Console.WriteLine("Enter value N:");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int Sum(int number)
{
    if (number % 10 == 0)
    {
        return 0;
    }
    Sum(number / 10);
    return Math.Abs(sum += number % 10);
}

Console.WriteLine($"Sum of digits = {Sum(n)}");
