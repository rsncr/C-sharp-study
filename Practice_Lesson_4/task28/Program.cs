//Напишите программу, которая на вход принимает число А и выдает произведение чисел от 1 до А

Console.Write("Введите число A: ");

int number = Convert.ToInt32(Console.ReadLine());
int sum = number;
if(number >= 0)
{
for(int i = 1; i < number; i++)
{
    sum = i * sum;
}
Console.WriteLine(sum);
}
else 
{
   for(int i = -1; i > number; i--)
{
    sum = i * sum;
}
Console.WriteLine(sum); 
}
