var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("********* Součet cifer ********");
    Console.WriteLine("*******************************");
    Console.WriteLine("******** Linda Kastlová *******");
    Console.WriteLine("********** 13.10.2025 *********");
    Console.WriteLine("*******************************");
    Console.WriteLine();


    Console.Write("Zadejte první číslo (celé číslo): ");

    int input;
    while (!int.TryParse(Console.ReadLine(), out input))
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");

    Console.Write("Chte soušin [0] nebo součet [1]?: ");

    int sum;
    while (!int.TryParse(Console.ReadLine(), out sum) || (sum != 0 && sum != 1))
        Console.Write("Nezadali jste 0 nebo 1. Chte soušin [0] nebo součet [1]?: ");

    Console.Clear();

    var inlineNumbers = input.ToString().ToList();

    var result = sum == 0 ? 1 : 0;

    foreach (var stringNumber in inlineNumbers)
    {
        var number = int.Parse(stringNumber.ToString());

        Console.WriteLine($"Příčítám k {result} číslo {number}...");

        if (sum == 0)
            result *= number;
        else
            result += number;
    }

    var prefix = sum == 0 ? "Součin" : "Součet";
    Console.WriteLine($"{prefix} všech {inlineNumbers.Count} číslic ze základu {input} je {result}!");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}