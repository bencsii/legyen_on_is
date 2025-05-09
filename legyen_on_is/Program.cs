namespace legyen_on_is
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			List<string> kerdesLista = new List<string>();
			Kerdesek.Beeolvas(kerdesLista);

            foreach (var item in kerdesLista)
            {
				Console.WriteLine(item);
            }


        }
	}
}
