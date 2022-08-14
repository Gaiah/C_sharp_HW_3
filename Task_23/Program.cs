Console.WriteLine("Enter some number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
userNumber = Math.Abs(userNumber);
int consoleNum = 1;

while (consoleNum <= userNumber)
{
    Console.Write($" {consoleNum} cubed is: ");
    Console.WriteLine (Math.Pow(consoleNum, 3));
    consoleNum++;
}