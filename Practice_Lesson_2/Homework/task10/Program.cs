Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int m = Math.Abs(a); //конвертация в модуль от введеного числа

if (m > 99 && m < 1000)
{
int b = m % 100;
int c = (b - (b % 10)) / 10;
Console.WriteLine($"Вторая цифра введенного числа: {c}");
}
else
Console.WriteLine("Ошибка ввода, число не трехзначное");