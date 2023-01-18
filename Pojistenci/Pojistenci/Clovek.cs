using System;
namespace Pojistenci
{
	class Clovek
	{
		public string Jmeno { get; private set; }
		public string Prijmeni { get; private set; }
		public int Vek { get; private set; }
		public int TelCislo { get; set; }


		public Clovek(string jmeno, string prijmeni, int vek, int telCislo)
		{
			Jmeno = jmeno;
			Prijmeni = prijmeni;
			Vek = vek;
			TelCislo = telCislo;
		}

        public override string ToString()
        {
            return $"{Jmeno.PadRight(12)}{Prijmeni.PadRight(12)}{Vek.
				ToString().PadRight(5)}{TelCislo.ToString().PadRight(10)}";
        }
    }
}

