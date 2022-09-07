 double Factorial (int n)
 {
     if (n == 1) return n;
     else return Factorial(n-1) * n; 
 } 
 Console.WriteLine(Factorial(6));