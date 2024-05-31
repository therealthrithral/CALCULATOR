string? readResult;

Console.Clear();
RunCalculator();

// main method for calculator functions.
void RunCalculator()
{
    const string enterFirstNumber = "Please enter your first number.";
    const string enterSecondNumber = "Please enter your second number.";
    const string unableToParse = "String could not be parsed.";

    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;

    CalcMenu();

    // Switch Case for math operations
    switch (readResult)
    {
        case "+":

            Console.WriteLine("You chose Addition. ");

            Console.WriteLine(enterFirstNumber);
            readResult = Console.ReadLine();
            if (!Int32.TryParse(readResult, out firstNumber))
            {
                Console.WriteLine(unableToParse);
            }

            Console.WriteLine(enterSecondNumber);
            readResult = Console.ReadLine();
            if (!Int32.TryParse(readResult, out secondNumber))
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
            if (!Int32.TryParse(readResult, out firstNumber))
            {
                Console.WriteLine(unableToParse);
            }

            Console.WriteLine(enterSecondNumber);
            readResult = Console.ReadLine();
            if (!Int32.TryParse(readResult, out secondNumber))
            {
                Console.WriteLine(unableToParse);
            }
            try
            {
                result = firstNumber / secondNumber;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"DivideByZero Exception Caught : {ex.Message}");
            }
            Console.WriteLine($"Your answer is: {firstNumber} / {secondNumber} = {result}");
            break;

        case "-":

            Console.WriteLine("You chose Subtraction");

            Console.WriteLine(enterFirstNumber);
            readResult = Console.ReadLine();
            if (!Int32.TryParse(readResult, out firstNumber))
            {
                Console.WriteLine(unableToParse);
            }

            Console.WriteLine(enterSecondNumber);
            readResult = Console.ReadLine();
            if (!Int32.TryParse(readResult, out secondNumber))
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
            if (!Int32.TryParse(readResult, out firstNumber))
            {
                Console.WriteLine(unableToParse);
            }

            Console.WriteLine(enterSecondNumber);
            readResult = Console.ReadLine();
            if (!Int32.TryParse(readResult, out secondNumber))
            {
                Console.WriteLine(unableToParse);
            }

            result = firstNumber * secondNumber;
            Console.WriteLine($"Your answer is: {firstNumber} * {secondNumber} = {result}");
            break;
        case "%%":
            CalcFizzBuzz();
            break;
    }
}

// Additional Methods to clean up code.  To add an operation, create a method, and then update the switch case accordingly. (I still need to do this)
// Make sure to update CalcMenu method as well.

void CalcMenu()
{
    Console.WriteLine("Please enter the symbol for the corresponding equation:");
    Console.WriteLine("Enter '/' for Integer Division");
    Console.WriteLine("Enter '+' for Addition");
    Console.WriteLine("Enter '-' for Subtraction");
    Console.WriteLine("Enter '*' for Multiplication");
    Console.WriteLine("Enter '%%' for FizzBuzz 1 - 100");
    Console.WriteLine();
    Console.WriteLine("Press Enter to exit");
    readResult = Console.ReadLine();
}

void CalcFizzBuzz()
{
    for (int i = 1; i < 101; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine($"{i} - FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine($"{i} - Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine($"{i} - Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}