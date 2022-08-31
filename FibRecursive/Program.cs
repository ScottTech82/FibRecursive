
using System.Reflection.Emit;

Console.WriteLine("Fib Recursive!");


fib(1, 1);

void fib(int a, int b)
{
    var c = a + b; // creating c to print later
    if (c > 100) return;
    Console.WriteLine($"{c}, ");
    fib(b, c);
}
