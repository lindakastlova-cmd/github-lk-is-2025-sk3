using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*****************************************");
    Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
    Console.WriteLine("*****************************************");
    Console.WriteLine("************* Linda Kastlová ************");
    Console.WriteLine("*************** 20.11.2025 **************");
    Console.WriteLine("*****************************************");
    Console.WriteLine();

    
    // Vstup číselné hodnoty do programu 
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    Console.Write("Zadejte dolní mez generovaných čísel (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }
    
    Console.Write("Zadejte horní mez generovaných čísel (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }
    
    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}, dolní mez: {1}, horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("===========================================");
    Console.WriteLine();
    
    //Deklarace pole - uložiště čísel
    int[] myRandNumbers = new int[n];
    
    //Příprava pro generování náhodných čísel
    //Random myRandNumber = new Random(); 
    Random randomGenerator = new Random(25); 
    
    
    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");

  
    for(int i = 0; i < n; i++)
    {
        myRandNumbers[i] = randomGenerator.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ",myRandNumbers[i]);
    }

    int compare = 0; //proměnná pro počet porovnávání
    int change = 0; //proměnná pro počet výměn
    
    Stopwatch myStopwatch = new Stopwatch();
    
    myStopwatch.Start();
    
    for(int i = 0; i < n - 1; i++) {
        for(int j = 0; j < n - i - 1; j++)
        {
            if (myRandNumbers[j] < myRandNumbers[j+1])
            {
                int tmp = myRandNumbers[j+1];
                myRandNumbers[j+1] = myRandNumbers[j];
                myRandNumbers[j] = tmp;
                change++;
            }
             compare++;
        }
    }
    myStopwatch.Stop();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("============================================");
    Console.WriteLine("Seřazená pole:");
    Console.WriteLine();
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", myRandNumbers[i]);
    }

    //Nalezení druhého největšího čísla
    //for(int i = 0; i < n - 2; i++)
  
    
    Console.WriteLine();
    Console.WriteLine("Druhé největší čílo: ");

    int secondBiggest = myRandNumbers[1];
    Console.Write("{0}", secondBiggest);
    Console.WriteLine();

    /*
    Console.WriteLine();
    Console.WriteLine("============================================");
    Console.WriteLine("Počet porovnání: {0}", compare);
    Console.WriteLine("Počet výměn: {0}", change);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Čas potřebný na seřazení čísel pomocí BS: {0}", myStopwatch.Elapsed);
     */
     
    //Vykreslení obdelníku na základě druhého největšího čísla
    int height = secondBiggest;
    int width = secondBiggest / 2;
    
    Console.WriteLine($"{height} h a {width} w");
    
    for(int row = 0; row < height; row++) {
        for (int column = 0; column < width; column++)
        {
            if (row < 2 || row >= height - 2)
            {
                Console.Write("* ");   
            }
            else if (column == 0 || column == width - 1)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
    
    
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}