using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyen_on_is
{
    internal class Segitseg
    {
        internal Random rnd = new Random();
        public List<string> Felezo(Kerdes kerdes)
        {
            List<string> maradekV = new List<string>();
            List<int> rosszVIndexek = new List<int>();


            string helyesV = kerdes.HelyesValasz.ToUpper();
            int helyesIndex = helyesV[0] - 'A';
            maradekV.Add(kerdes.ValaszokLista[helyesIndex]);

            
            for (int i = 0; i < kerdes.ValaszokLista.Count; i++)
            {
                if (i != helyesIndex)
                {
                    rosszVIndexek.Add(i);

                }
            }

            int randomIndex = rosszVIndexek[rnd.Next(rosszVIndexek.Count)];
            maradekV.Add(kerdes.ValaszokLista[randomIndex]);

            return maradekV;
        }

        public void TelefonosSegitseg(Kerdes kerdes)
        {
            int randomValasz = rnd.Next(kerdes.ValaszokLista.Count);
            char betu = (char)('A' + randomValasz);

            Console.WriteLine($"Kedves betelefonalonk szerint a valasz : {betu}");
        }

        public void KozonsegSegit(Kerdes kerdes)
        {
            string helyesValasz = kerdes.HelyesValasz.ToUpper();
            int helyesBetu = helyesValasz[0] - 'A';
            int[] szavazatok = new int[4];         
            int helyesSzazalek = rnd.Next(60, 81); 

            szavazatok[helyesBetu] = helyesSzazalek;

            
            int maradek = 100 - helyesSzazalek;
            List<int> rosszBetuk = new List<int> { 0, 1, 2, 3 };
            rosszBetuk.Remove(helyesBetu);

            
            for (int i = 0; i < rosszBetuk.Count; i++)
            {
                int oszthato = (i < rosszBetuk.Count - 1) ? rnd.Next(0, maradek + 1) : maradek;
                szavazatok[rosszBetuk[i]] = oszthato;
                maradek -= oszthato;
            }

            
            Console.WriteLine("Kozonseg szavazatai: ");
            for (int i = 0; i < 4; i++)
            {
                char valaszBetu = (char)('A' + i);
                Console.WriteLine($"{valaszBetu}: {szavazatok[i]}%");
            }
        }


    }
}
