Console.WriteLine("Welcome to my Calculator.  Type in START to begin or type EXIT to terminate the program.");

string? readResult = Console.ReadLine();

readResult = readResult.Trim().ToUpper();

if (readResult.Equals("START"))
{
    RunCalculator();
}
else if (readResult.Equals("EXIT"))
{
    Console.WriteLine("Goodbye!");
}

// main method for calculator functions.
void RunCalculator()
{
    const string enterFirstNumber = "Please enter your first number.";
    const string enterSecondNumber = "Please enter your second number.";
    const string unableToParse = "String could not be parsed.";

    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;

    Console.WriteLine("Please enter the symbol for the corresponding equation (/, +, -, *)");
    readResult = Console.ReadLine();

    switch (readResult)
    {
        case "+":

            Console.WriteLine("You chose Addition. ");

            Console.WriteLine(enterFirstNumber);
            readResult = Console.ReadLine();
            if (Int32.TryParse(readResult, out firstNumber))
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(unableToParse);
            }

            Console.WriteLine(enterSecondNumber);
            readResult = Console.ReadLine();
            if (Int32.TryParse(readResult, out secondNumber))
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(unableToParse);
            }

            result = firstNumber + secondNumber;
            Console.WriteLine($"Your answer is: {firstNumber} + {secondNumber} = {result}");
            break;

        case "/":

            Console.WriteLine("You chose Division");

            Console.WriteLine(enterFirstNumber);
            readResult = Console.ReadLine();
            if (Int32.TryParse(readResult, out firstNumber))
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(unableToParse);
            }

            Console.WriteLine(enterSecondNumber);
            readResult = Console.ReadLine();
            if (Int32.TryParse(readResult, out secondNumber))
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(unableToParse);
            }

            result = firstNumber / secondNumber;
            Console.WriteLine($"Your answer is: {firstNumber} / {secondNumber} = {result}");
            break;

        case "-":

            Console.WriteLine("You chose Subtraction");

            Console.WriteLine(enterFirstNumber);
            readResult = Console.ReadLine();
            if (Int32.TryParse(readResult, out firstNumber))
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(unableToParse);
            }

            Console.WriteLine(enterSecondNumber);
            readResult = Console.ReadLine();
            if (Int32.TryParse(readResult, out secondNumber))
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(unableToParse);
            }

            result = firstNumber - secondNumber;
            Console.WriteLine($"Your answer is: {firstNumber} - {secondNumber} = {result}");

            break;

        case "*":

            Console.WriteLine("You chose Multiplication");

            Console.WriteLine(enterFirstNumber);
            readResult = Console.ReadLine();
            if (Int32.TryParse(readResult, out firstNumber))
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(unableToParse);
            }

            Console.WriteLine(enterSecondNumber);
            readResult = Console.ReadLine();
            if (Int32.TryParse(readResult, out secondNumber))
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(unableToParse);
            }

            result = firstNumber * secondNumber;
            Console.WriteLine($"Your answer is: {firstNumber} * {secondNumber} = {result}");
            break;
    }
}