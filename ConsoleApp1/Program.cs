decimal num1 = 0; decimal num2 = 0; string operator_ = ""; decimal result = 0;
Console.WriteLine("This is a calculator in c#\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Insert a number and press enter");
num1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Insert the numerical operator and press enter ");
operator_ = Console.ReadLine();
Console.WriteLine("Insert another number and press enter");
num2 = Convert.ToDecimal(Console.ReadLine());

switch (operator_)
{
    case "+":
        result = num1 + num2;
        Console.WriteLine($"Your result is: {num1} + {num2} = " + result);
        break;
    case "-":
        result = num1 - num2;
        Console.WriteLine($"Your result is: {num1} - {num2} = " + result);
        break;
    case "*":
        result = num1 * num2;
        Console.WriteLine($"Your result is: {num1} * {num2} = " + result);
        break;
    case "/":
        result = num1 / num2;
        Console.WriteLine($"Your result is: {num1} / {num2} = " + result);
        break;
}
Console.WriteLine("Press any key to close the Calculator console app...");
Console.ReadKey();
