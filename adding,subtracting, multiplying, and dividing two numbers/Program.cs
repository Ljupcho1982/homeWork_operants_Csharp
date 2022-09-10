
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Enter a number: ");

int x=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a second number: ");

int y=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{x}+{y}={x + y}");

Console.WriteLine($"{x}-{y}={x - y}");

Console.WriteLine($"{x}*{y}={x * y}");

Console.WriteLine($"{x}/{y}={x/y}");

Console.WriteLine($"{x}%{y}={x % y}");

