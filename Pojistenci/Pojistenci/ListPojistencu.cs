using System;
using System.Collections.Generic;
using System.Linq;

namespace Pojistenci
{
	class ListPojistencu
	{
		List<Clovek> databazePojistencu = new List<Clovek>();

		/// <summary>
		/// Přidání pojištěnce
		/// </summary>
		/// <param name="clovek"></param>
		public void PridejPojistence(Clovek clovek)
		{
			databazePojistencu.Add(clovek);
		}

		/// <summary>
		/// Výpis všech pojištěnců
		/// </summary>
		public void VypisPojisencu()
		{
			foreach (Clovek clovek in databazePojistencu)
			{
				Console.WriteLine(clovek);
			}
		}

		/// <summary>
		/// Vyhledání pojištěnce
		/// </summary>
		/// <param name="jmeno">Jméno</param>
		/// <param name="prijmeni">Příjmení</param>
		public void VyhledejPojistence(string jmeno, string prijmeni)
		{
			if (databazePojistencu.Count() > 0) { 
                Console.WriteLine("\nNalezený pojištěnec:");
				Console.WriteLine("\nJméno".PadRight(12) + "Příjmení".PadRight(12) +
                "Věk".PadRight(5) + "TelČíslo".PadRight(9));
				Console.WriteLine("--------------------------------------");
            }
            else
                Console.WriteLine("\nPojištěnec nenalezen");

            foreach (Clovek clovek in databazePojistencu)
			{
				if (jmeno.ToLower() == clovek.Jmeno.ToLower() && prijmeni.ToLower() == clovek.Prijmeni.ToLower())
					Console.WriteLine(clovek);
            }
        }
	}
}

