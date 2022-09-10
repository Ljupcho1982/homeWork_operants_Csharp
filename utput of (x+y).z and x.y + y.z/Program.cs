




void multiplythreenumbers()

{
    Console.WriteLine("Enter a number:");

    int x = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Enter a second number:");

    int y = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Enter a third number:");

    int z = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"The result of specified numbers:{x},{y},{z} is {x} + {y} * {z} ={(x+y)*z} and {x}*{y}+{y}*{z}={(x*y)+(y*z)}");


};

multiplythreenumbers();
