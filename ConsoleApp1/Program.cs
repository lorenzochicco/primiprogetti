int num1 = 0; int num2 = 0;
Console.WriteLine("Questo è un calcolatore in c#\r");
Console.WriteLine("------------------------\n");
Console.WriteLine("Inserisci un numero e premi invio");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci un altro numero e premi invio");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Scegli che operatore utilizzare tra i seguenti e premi invio");
Console.WriteLine(" \ta = somma");
Console.WriteLine(" \ts = sottrazione");
Console.WriteLine(" \tm = moltiplicazione");
Console.WriteLine(" \td = divisione");
Console.Write("Cosa scegli? ");
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}
Console.WriteLine("Press any key to close the Calculator console app...");
Console.ReadKey();