Console.Write("Введите число дня недели 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a > 0 && a < 6)
{
   Console.WriteLine("День не явлется выходным");
}
if(a > 5 && a < 8)
{
   Console.WriteLine("Выходной");
}
if(a > 7)
{
   Console.WriteLine("Ошибка ввода. Введите число дня недели от 1 до 7.");
}