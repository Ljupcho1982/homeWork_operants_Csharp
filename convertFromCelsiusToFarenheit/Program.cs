
Console.WriteLine("Enter temperature in Celsius degrees: ");

decimal x=Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Kelivin {x + (273.15M)} and Farenheit is:{x * (9M / 5M) + 32M}");


