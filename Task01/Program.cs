Console.WriteLine("Type your first number ");
double numberA = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Type your second number ");
double numberB = Convert.ToDouble (Console.ReadLine());
if(numberA == numberB * numberB)
{
    Console.WriteLine($"{numberB} is a square root of {numberA}");
}
else {
Console.WriteLine($"{numberB} is not a square root of {numberA} ");
};
