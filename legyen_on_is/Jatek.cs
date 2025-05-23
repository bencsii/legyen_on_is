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
			Kerdesek kerdesLista = new Kerdesek();
			kerdesLista.Beolvas("kerdes.txt");
			

			
			do
			{
				Console.WriteLine($"Jelenlegi szint: {jatekosSzint}");
				
				Console.WriteLine($"Kerdesek szama : {kerdesLista.KerdesLista.Count}");
				Kerdes kerdes = kerdesLista.KerdesLista[rnd.Next(0, 500)];
				Console.WriteLine($"Kerdes szint : {kerdes.Szint}");

				for (int i =0; i < kerdesLista.KerdesLista.Count; i++)
				{
					
					if (kerdesLista.KerdesLista[i].Szint == jatekosSzint.ToString())
					{
						Console.WriteLine($"Kerdes: {kerdes.KerdesSz}");
						break;
						
					}
					


				}
				

				Console.WriteLine($"Kategoria: {kerdes.Kategoria}");
				


				char betu = 'A';
				foreach (string valasz in kerdes.ValaszokLista)
				{
					Console.WriteLine($"{betu} {valasz}");
					betu++;
				}

				Console.Write("Adja meg a valaszt ABCD : ");
				string Svalasz = Console.ReadLine().ToUpper();
				if (Svalasz == kerdes.HelyesValasz)
				{
					Console.WriteLine($"Helyes valasz: {kerdes.HelyesValasz}");
					jatekosSzint++;
				}
				else
				{
					Console.WriteLine("Helytelen valasz");
					Console.WriteLine($"Helyes valasz: {kerdes.HelyesValasz} LETT VOLNA");
				}
			} while (jatekosSzint != 10);
			//Console.WriteLine($"Helyes valasz: {kerdes.HelyesValasz}");
			

			
		}
	}
}
