Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 && a < 1000)
{
int b = a % 100;
int c = (b - (b % 10)) / 10;
Console.WriteLine($"Вторая цифра введенного числа: {c}");
}
else
Console.WriteLine("Ошибка ввода, число не трехзначное");