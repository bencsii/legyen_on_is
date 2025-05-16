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


        public List<string> ValaszokLista { get => valaszokLista; set => valaszokLista = value; }
        public string HelyesValasz { get => helyesValasz; set => helyesValasz = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public string KerdesSz { get => kerdesSz; set => kerdesSz = value; }



        public Kerdes(string kerdesSz,List<string> valaszokLista, string helyesValasz, string kategoria)
		{
			ValaszokLista = valaszokLista;
			HelyesValasz = helyesValasz;
			Kategoria = kategoria;
            KerdesSz = kerdesSz;
        }

        
    }

}
