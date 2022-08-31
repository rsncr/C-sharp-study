// числа Фибоначчи определяются следующим образом:
// f(0) = 0;
// f(1) = 1;
// f(2) = f(1) + f(0) = 1
// f(3) = f(2) + f(1) = 2
// f(n) = f(n-1) + f(n-2) 

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 24; i++)
{
    Console.WriteLine(Fibonacci(i));
}