using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyen_on_is
{
	internal class Kerdesek
	{
		List<Kerdes> kerdesek = new List<Kerdes>();

		

		public static void Beeolvas(List<string> kerdesek)
		{
			string[] lines = File.ReadAllLines("kerdes.txt");
			foreach (string line in lines)
			{
				kerdesek.Add(line);
				
				
				
			}
		}

	}

	
}
