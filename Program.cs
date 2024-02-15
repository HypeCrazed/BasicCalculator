Console.Title = "BasicCalculator";

while (true)
{
    Console.WriteLine("Enter the first number...");
    var firstNumber = Console.ReadLine();

    Console.WriteLine("Enter the second number...");
    var secondNumber = Console.ReadLine();

    Console.WriteLine("What do you want to do? (add, divide, subtract, multiply)");
    var method = Console.ReadLine();

    int num1 = int.Parse(firstNumber);
    int num2 = int.Parse(secondNumber);

    if (method == "add")
    {
        int result = num1 + num2;
        Console.WriteLine($"The answer is {result}");
    }

    if (method == "divide")
    {
        if (num2 != 0)
        {
            int result = num1 / num2;
            Console.WriteLine($"The answer is {result}");
        }
        else
        {
            Console.WriteLine("Can't divide by zero.");
        }
    }

    if (method == "subtract")
    {
        int result = num1 - num2;
        Console.WriteLine($"The answer is {result}");
    }

    if (method == "multiply")
    {
        int result = num1 * num2;
        Console.WriteLine($"The answer is {result}");
    }

    Console.Write("\nPress any key to do another problem.");
    Console.ReadKey();
    Console.Clear();
}
