var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("****** Výpis číselné řady *****");
    Console.WriteLine("*******************************");
    Console.WriteLine("******** Linda Kastlová *******");
    Console.WriteLine("********** 02.10.2025 *********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    // Vstup číselné hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());


    // Vstup číselné hodnoty do programu - lépe řešené
    Console.Write("Zadejte první číslo řady (celé číslo): ");

    int input;
    while (!int.TryParse(Console.ReadLine(), out input))
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");

    
    
    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}