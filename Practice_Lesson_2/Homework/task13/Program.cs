Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int m = Math.Abs(a); //конвертация в модуль от введеного числа

if(m > -100 && m < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
int digitIndex = 2;
int digit = m.ToString()[digitIndex] - '0';
Console.WriteLine(digit);
}