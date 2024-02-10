Console.ForegroundColor = ConsoleColor.Blue;
Console.Title = "Basic Calculator by HypeCrazed";

Console.WriteLine("Enter the first number...");
var FirstNumber = Console.ReadLine();

Console.WriteLine("Enter the second number...");
var SecondNumber = Console.ReadLine();

Console.WriteLine("What do you want to do? (add, divide, subtract, multiply)");
var method = Console.ReadLine();

int num1 = int.Parse(FirstNumber);
int num2 = int.Parse(SecondNumber);

if (method == "add")
{
    int result = num1 + num2;
    Console.WriteLine(result);
}

if (method == "divide")
{
    if (num2 != 0)
    {
        int result = num1 / num2;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Can't divide by zero.");
    }
}

if (method == "subtract")
{
    int result = num1 - num2;
    Console.WriteLine(result);
}

if (method == "multiply")
{
    int result = num1 * num2;
    Console.WriteLine(result);
}

Console.ReadKey();
