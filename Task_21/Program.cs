Console.WriteLine("Enter X1: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y1: ");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z1: ");
int numZ1 = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Enter X2: ");
double numX2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Y2: ");
double numY2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Z2: ");
double numZ2 = Convert.ToDouble(Console.ReadLine());
double distanceAB;


Console.WriteLine($" Point1({numX1}, {numY1}, {numZ1}) ; Point2({numX2}, {numY2}, {numZ2})");

Console.Write("The distance between Point1 and Point2 = ");
Console.WriteLine(distanceAB = Math.Sqrt(Math.Pow((numX2 - numX1), 2) + Math.Pow((numY2 - numY1), 2) + Math.Pow((numZ2 - numZ1),2)));