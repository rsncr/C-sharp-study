Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a > -100 && a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
int digitIndex = 2;
int digit = a.ToString()[digitIndex] - '0';
Console.WriteLine(digit);
}