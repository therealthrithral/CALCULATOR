string? readResult;

Console.Clear();
RunCalculator();

// main method for calculator functions.
void RunCalculator()
{

    double result = 0;

    Console.WriteLine("Enter numbers separated by spaces");
    string input = Console.ReadLine();
    double[] numbers = input.Split(' ').Select(double.Parse).ToArray();
    CalcMenu();

    // Switch Case for math operations
    switch (readResult)
    {
        case "+":

            Console.WriteLine("You chose Addition. ");
            result = Add(numbers);
            Console.WriteLine(result);

            break;

        case "/":

            Console.WriteLine("You chose Division");
            result = Divide(numbers);
            Console.WriteLine(result);

            break;

        case "-":

            Console.WriteLine("You chose Subtraction");
            result = Subtract(numbers);
            Console.WriteLine(result);

            break;

        case "*":

            Console.WriteLine("You chose Multiplication");
            result = Multiply(numbers);
            Console.WriteLine(result);

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
    Console.WriteLine("Enter '/' for Division");
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

double Add(double[] numbers)
{
    return numbers.Sum();
}

double Subtract(double[] numbers)
{
    double result = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        result -= numbers[i];
    }
    return result;
}

double Multiply(double[] numbers)
{
    double result = 1;
    foreach (double num in numbers)
    {
        result *= num;
    }
    return result;
}

double Divide(double[] numbers)
{
    double result = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] == 0)
        {
            Console.WriteLine("Divide By Zero encountered.");
            return double.NaN; // Not a Number
        }
        result /= numbers[i];
    }
    return result;
}