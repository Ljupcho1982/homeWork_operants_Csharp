
void swapNumbers()
{

    Console.WriteLine("Enter a number");
   int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter a another number");

   int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Before swaping the value x is {x} and value y is {y}");

    (x, y) = (y, x);

    Console.WriteLine($"Before swaping the value x is {x} and value y is {y}");


}

swapNumbers();
