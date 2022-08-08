Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

int remaining1 = a % 7;
int remaining2 = a % 23;

if(remaining1 == 0 && remaining2 == 0)
{
    Console.WriteLine("Число 1 является кратным 7 и 23");
}
else
{
    Console.WriteLine("Число 1 НЕ является кратным 7 и 23");
}