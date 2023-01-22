// See https://aka.ms/new-console-template for more information


using Pojistenci;

//Výpis nadpisu
static void VypisNadpis()
{
    Console.Clear();
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Evidence pojištěných");
    Console.WriteLine("-----------------------------\n");
}

ListPojistencu listPojistencu = new ListPojistencu();

bool pokracovat = true;

while (pokracovat)
{
    //Výpis menu
    VypisNadpis();
    Console.WriteLine("Vyberte si akci");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec programu");


    //Uživatelské akce
    char volba = Console.ReadKey().KeyChar;
    switch (volba)
    {
        case '1':
            VypisNadpis();
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine().Trim();
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni = Console.ReadLine().Trim();
            Console.WriteLine("Zadejte věk pojištěného:");
            int vek, telCislo;
            while (!int.TryParse(Console.ReadLine().Trim(), out vek)) ;
            Console.WriteLine("Zadejte telefonní číslo pojištěného:");
            while (!int.TryParse(Console.ReadLine().Trim(), out telCislo)) ;
            listPojistencu.PridejPojistence(new Clovek(jmeno, prijmeni, vek, telCislo));
            Console.WriteLine("\nData uložena.");
            break;
        case '2':
            VypisNadpis();
            Console.WriteLine("Seznam pojištěnců:\n");
            Console.WriteLine("Jméno".PadRight(12) + "Příjmení".PadRight(12) +
                "Věk".PadRight(5) + "TelČíslo".PadRight(9));
            Console.WriteLine("--------------------------------------");
            listPojistencu.VypisPojisencu();
            break;
        case '3':
            VypisNadpis();
            Console.WriteLine("Zadejte hledané jméno:");
            jmeno = Console.ReadLine().Trim();
            Console.WriteLine("Zadejte hledané příjmení:");
            prijmeni = Console.ReadLine().Trim();
            listPojistencu.VyhledejPojistence(jmeno, prijmeni);
            break;
        case '4':
            pokracovat = false;
            break;
        default:
            Console.WriteLine("\nNeplatné zadání!");
            break;
    }
    Console.WriteLine("\n\nPokračujte libovolnou klávesou...");
    Console.ReadKey();
    Console.Clear();
}
