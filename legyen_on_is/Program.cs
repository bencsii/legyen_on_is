namespace legyen_on_is
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Kerdesek kerdesLista = new Kerdesek();
            kerdesLista.Beolvas("kerdes.txt");
            Console.WriteLine($"Kerdesek szama : {kerdesLista.KerdesLista.Count}");
            Kerdes kerdes = kerdesLista.KerdesLista[3];

            Console.WriteLine($"Kategoria: {kerdes.Kategoria}");
            Console.WriteLine($"Kerdes: {kerdes.KerdesSz}");

            char betu = 'A';
            foreach (string valasz in kerdes.ValaszokLista)
            {
                Console.WriteLine($"{betu} {valasz}");
                betu++;
            }

            Console.WriteLine($"Helyes valasz: {kerdes.HelyesValasz}");

        }
    }
}

