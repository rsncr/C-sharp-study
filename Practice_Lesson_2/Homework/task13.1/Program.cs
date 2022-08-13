Console.Write("Введите число: ");
string a = Console.ReadLine();

if(a.Contains("-"))
{
    if (a.Length < 4)
    { 
        Console.WriteLine("Третьей цифры нет");  
    }
else
    {
    char b = a[3];
    Console.WriteLine(b);
    }
}
else
{
    if (a.Length < 3)
    { 
        Console.WriteLine("Третьей цифры нет");  

    }
    else
    {
        char b = a[2];
        Console.WriteLine(b);
    }
}
