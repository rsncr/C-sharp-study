for(int i = 2; i <= 10; i++) //цикл for компактнее while и
//собирает все переменные для  цикла в одной строке через точку с запятой
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}