Console.Write("Введите номер четверти (1-4): ");
int a = Convert.ToInt32(Console.ReadLine());

if(a>4 || a<1)
{
    Console.WriteLine("Ошибка, номер четерти должен быть от 1 до 4");    
}
else if(a==1)
{
    Console.WriteLine($"Возможные значения X в данной четверти: от {1} до {Int32.MaxValue}");
    Console.WriteLine($"Возможные значения Y в данной четверти: от {1} до {Int32.MaxValue}");
}
else if(a==2)
{
    Console.WriteLine($"Возможные значения X в данной четверти: от {1} до {Int32.MaxValue}");
    Console.WriteLine($"Возможные значения Y в данной четверти: от {Int32.MinValue} до {-1}");
}
else if(a==3)
{
    Console.WriteLine($"Возможные значения X в данной четверти: от {Int32.MinValue} до {-1}");
    Console.WriteLine($"Возможные значения Y в данной четверти: от {Int32.MinValue} до {-1}");
}
else if(a==4)
{
    Console.WriteLine($"Возможные значения X в данной четверти: от {Int32.MinValue} до {-1}");
    Console.WriteLine($"Возможные значения Y в данной четверти: от {1} до {Int32.MaxValue}");
    }