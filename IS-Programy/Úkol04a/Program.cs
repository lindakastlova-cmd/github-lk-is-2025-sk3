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


    Console.Write("Zadejte první číslo řady (celé číslo): ");

    int input;
    while (!int.TryParse(Console.ReadLine(), out input))
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");

    var temp = input;
    var result = 0;
    var numberCount = 0;

    while (temp > 0)
    {
        var part = temp % 10;
        var resultSave = result;

        temp /= 10;
        numberCount++;
        result *= part;

        Console.WriteLine(
            $"Při interaci {numberCount} jsem k číslu {resultSave} vynásobil {part} a to dělá výsledek {result} a zbývá  {temp} ke zpracování");
    }

    Console.WriteLine($"Součin všechn {numberCount} číslic ze základu {input} je {result}!");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}