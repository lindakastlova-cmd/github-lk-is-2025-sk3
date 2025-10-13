string again = "a";
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
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }
    
    int temp = input;
    int result = 0;
    int numberCount = 0;
    
    while (temp > 0)
    {
       int part = temp % 10;
       int resultSave = result;
       
       temp /= 10;
       numberCount++;
       result +=  part;  
       
       Console.WriteLine ($"Při interaci {numberCount} jsem k číslu {resultSave} přičetl {part} a to dělá výsledek {result} a zbývá  {temp} ke zpracování");
    }
    
    Console.WriteLine ($"Součet všechn {numberCount} číslic ze základu {input} je {result}!");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}