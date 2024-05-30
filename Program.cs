Console.WriteLine("Welcome to my Calculator.  Type in START to begin!");

string readResult = Console.ReadLine();

readResult = readResult.Trim().ToUpper();

if (readResult.Equals("START"))
{
    // RunCalculator()
}
else
{
    Console.WriteLine("Goodbye!");
}

void RunCalculator()
{
    Console.WriteLine("Please enter the symbol for the corresponding equation (/, +, -, *)");
}