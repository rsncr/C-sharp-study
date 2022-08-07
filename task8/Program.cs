Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;
while(count <= number)
{
    Console.Write(count );
    Console.Write(" ");
    count = count + 2;
}
