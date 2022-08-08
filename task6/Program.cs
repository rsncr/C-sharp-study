Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remaining = number % 2;

if (remaining == 0)
{
    Console.Write("Число явлется четным");
}
else
{
    Console.Write("Число явлется нечетным");
}

