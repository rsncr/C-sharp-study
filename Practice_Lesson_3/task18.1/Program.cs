Console.Write("Введите номер четверти (1-4): ");
int quarter = Convert.ToInt32(Console.ReadLine());

string[] array = {"x > 0; y > 0", "x > 0; y < 0", "x < 0; y < 0", "x < 0; y > 0"};

if(quarter > 0 && quarter < 5)
{
    Console.WriteLine(array[quarter-1]);
}
else
{
    Console.WriteLine("Такой четверти нет");
}