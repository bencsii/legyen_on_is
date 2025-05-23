using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyen_on_is
{
	internal class Kerdes
	{
		List<string> valaszokLista = new List<string>();
		string helyesValasz;
		string kategoria;
		string kerdesSz;
		string szint;

		public List<string> ValaszokLista { get => valaszokLista; set => valaszokLista = value; }
		public string HelyesValasz { get => helyesValasz; set => helyesValasz = value; }
		public string Kategoria { get => kategoria; set => kategoria = value; }
		public string KerdesSz { get => kerdesSz; set => kerdesSz = value; }
		public string Szint { get => szint; set => szint = value; }




		public Kerdes(string kerdesSz,List<string> valaszokLista, string helyesValasz, string kategoria, string szint)
		{

			ValaszokLista = valaszokLista;
			HelyesValasz = helyesValasz;
			Kategoria = kategoria;
            KerdesSz = kerdesSz;
			Szint = szint;
        }

		
	}

}
