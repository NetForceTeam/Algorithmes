using System;

namespace AlgorithmesDeCalcul
{
	class ValeurAbsolueNombreReel
	{
		static void Main(string[] args)
		{
			double x;
			Console.Write("Entrez un nombre x = ");
			try
			{
				x = Double.Parse(Console.ReadLine());
				if (x < 0)
				{
					Console.WriteLine("|x| = " + (-x));
				}
				else
				{
					Console.WriteLine("|x| = " + x);
				}
				Console.ReadLine();
			}
			catch (FormatException)
			{
				//...traitement de l'erreur de saisie 
			}
		}
	}
}
