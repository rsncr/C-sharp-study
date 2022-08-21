// Задайте массив. Напишите программу, которая определяет присутсвует ли заданное число в массиве


int[] array = new int[] {1, 3, 5, 7, 9, -11, 4, 12};
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int n = 0;

for(int i = 0; i < array.Length; i++)
{
    if (a == array[i])
    {
        n++;
    }
} 
if (n>0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

