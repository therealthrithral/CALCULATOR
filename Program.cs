Console.WriteLine("Welcome to my Calculator.  Type in START to begin!");

string readResult = Console.ReadLine();

readResult = readResult.Trim().ToUpper();

if (readResult.Equals("START"))
{
    RunCalculator();
}
else
{
    Console.WriteLine("Goodbye!");
}

void RunCalculator()
{
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    Console.WriteLine("Please enter the symbol for the corresponding equation (/, +, -, *)");
    readResult = Console.ReadLine();
    switch (readResult)
    {
        case "+":
            Console.WriteLine("You chose Addition. ");
            Console.WriteLine("Please enter your first number");
            readResult = Console.ReadLine();
            if (Int32.TryParse(readResult, out firstNumber))
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine("String could not be parsed");
            }
            Console.WriteLine("Please enter your second number");
            readResult = Console.ReadLine();
            if (Int32.TryParse(readResult, out secondNumber))
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine("String could not be parsed");
            }

            result = firstNumber + secondNumber;
            Console.WriteLine($"Your answer is: {firstNumber} + {secondNumber} = {result}");
            break;
    }
}