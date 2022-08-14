Console.WriteLine("Enter a five-digit number: ");
decimal num = Convert.ToDecimal(Console.ReadLine());
num = Math.Abs(num);

if (num > 9999 && num < 100000) 
{
    if (Math.Round(num / 10000, MidpointRounding.ToZero) == Math.Round(num % 10, MidpointRounding.ToZero))
    {
        if (Math.Round(num / 1000 % 10, MidpointRounding.ToZero) == Math.Round(num / 10 % 10, MidpointRounding.ToZero))
        {
            Console.WriteLine($"This is a palindromic number: {num}");
        }
        else
        {
            Console.WriteLine($"This isn't a palindromic number: {num} second couple failed");
        }
    }
    else 
    {
        Console.WriteLine($"This isn't a palindromic number: {num} first couple failed");
    }
}
else
{
    Console.WriteLine($"This is not a five-digit number: {num}");
}