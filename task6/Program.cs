Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number * -1;
while(count <= number)
{
    Console.Write(count );
    Console.Write(" ");
    count = count + 1;
}
