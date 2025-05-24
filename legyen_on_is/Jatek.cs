using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyen_on_is
{
	internal class Jatek
	{
		internal Random rnd = new Random();
		public void JatekIndit()
		{
			int jatekosSzint = 1;
            bool felezoHasznalt = false;
            bool telefonosHasznalt = false;
            bool kozonsegHasznalt = false;

            Dictionary<int, string> nyeremenyek = new Dictionary<int, string>()
			{
				{1, "1 000 Ft"},
				{2, "3 000 Ft"},
				{3, "6 000 Ft"},
				{4, "12 000 Ft"},
				{5, "25 000 Ft"}, 
				{6, "50 000 Ft"},
				{7, "100 000 Ft"},
				{8, "200 000 Ft"},
				{9, "400 000 Ft"},
				{10, "800 000 Ft"}, 
				{11, "1 500 000 Ft"},
				{12, "3 000 000 Ft"},
				{13, "6 000 000 Ft"},
				{14, "12 500 000 Ft"},
				{15, "25 000 000 Ft"}
			};
            Kerdesek kerdesLista = new Kerdesek();
            Segitseg segitseg = new Segitseg();
            kerdesLista.Beolvas("kerdes.txt");
			
			
			do
			{
				
				Console.WriteLine($"Jelenlegi szint: {jatekosSzint}");
				
				Console.WriteLine($"Kerdesek szama : {kerdesLista.KerdesLista.Count}");

                List<Kerdes> adottSzintuKerdesek = kerdesLista.KerdesLista
				.Where(k => k.Szint == jatekosSzint.ToString())
				.ToList();

                
                Kerdes kerdes = adottSzintuKerdesek[rnd.Next(adottSzintuKerdesek.Count)];

                Console.WriteLine($"Kerdes szint : {kerdes.Szint}");
                Console.WriteLine($"Kerdes: {kerdes.KerdesSz}");

                Console.WriteLine($"Kategoria: {kerdes.Kategoria}");



				char betu = 'A';
				foreach (string valasz in kerdes.ValaszokLista)
				{
					Console.WriteLine($"{betu} {valasz}");
					betu++;
				}
                Console.Write("Segitseg hasznalata : (f = 50/50, t = telefon, k = kozonseg, n = semmi): ");
				
                string segitsegH = Console.ReadLine().ToLower();
                
				if(segitsegH == "f" && !felezoHasznalt)
				{
                    List<string> felezettValaszok = segitseg.Felezo(kerdes);
                    Console.WriteLine("Felezo utan maradt valaszok:");
                    foreach (string valasz in felezettValaszok)
                    {
                        int index = kerdes.ValaszokLista.IndexOf(valasz);
                        char felezo = (char)('A' + index);
                        Console.WriteLine($"{felezo} {valasz}");
                    }
					felezoHasznalt = true;
                }
                else if (segitsegH == "t" && !telefonosHasznalt)
                {
                    segitseg.TelefonosSegitseg(kerdes);
                    telefonosHasznalt = true;
                }

				else if (segitsegH == "k" && !kozonsegHasznalt)
				{
					segitseg.KozonsegSegit(kerdes);
					kozonsegHasznalt= true;
					
				}



                Console.Write("Adja meg a valaszt ABCD : ");
				string Svalasz = Console.ReadLine().ToUpper();
				if (Svalasz == kerdes.HelyesValasz)
				{
					Console.WriteLine($"Helyes valasz: {kerdes.HelyesValasz}");
					Console.WriteLine($"Jelenlegi nyert osszeg : {nyeremenyek[jatekosSzint]}");
					jatekosSzint++;
				}
				else
				{
					Console.WriteLine("Helytelen valasz");
					Console.WriteLine($"Helyes valasz: {kerdes.HelyesValasz} LETT VOLNA");
				}

				if (jatekosSzint == 15)
				{
					Console.WriteLine($"Megnyerted a fodijat : {nyeremenyek[jatekosSzint]}");
				}
				Console.WriteLine("---------------------------------------------------------- \n");
			} while (jatekosSzint != 15);
			
			
			

			
		}

		
	}
}
