Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Math.Abs(N)];

int count = 1;

while(count <= Math.Abs(N))
{
    Console.Write($"{Math.Pow(count, 2)} ");
    count++;
}

