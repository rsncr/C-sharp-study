int[] array = {32, 14, 5, 333, 56, 43, 0, 31, 31};

int n = array.Length;

int find = 31;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
            Console.WriteLine(index);
            break;
    }
    index++;
}