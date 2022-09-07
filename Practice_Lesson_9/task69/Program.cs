// Напишите программу, которая на вход принимает два числа A и B, и возводит 
// число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Enter value A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value B:");
int b = Convert.ToInt32(Console.ReadLine());
int pow = 1;

int Pow(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    Pow(a, b - 1);
    return pow = pow * a;
}

Console.WriteLine($"A to the power of B = {Pow(a, b)}");
 