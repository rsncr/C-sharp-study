int number = new Random().Next(100,1000);
Console.WriteLine($"Наше случайное число: {number}");

int digit1 = number/100;
int digit2 = number%10;
int result = digit1*10+digit2;

Console.WriteLine(result);