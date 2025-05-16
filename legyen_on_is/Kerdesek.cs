using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyen_on_is
{
    internal class Kerdesek
    {
        private List<Kerdes> kerdesek = new List<Kerdes>();

        public List<Kerdes> KerdesLista { get => kerdesek; }


        public void Beolvas(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] item = line.Split(';');

                string kerdesSzoveg = item[1];
                List<string> valaszok = new List<string>
                {
                    item[2],
                    item[3],
                    item[4],
                    item[5]
                };

                string helyes = item[6].ToUpper();
                string kategoria = item[7];


                Kerdes ujKerdes = new Kerdes(kerdesSzoveg, valaszok, helyes, kategoria);
                kerdesek.Add(ujKerdes);

            }

        }


    }
}
