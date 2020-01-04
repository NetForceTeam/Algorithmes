// ===========================================================================
// Utilisation de la méthode static Sqrt(double x) de la classe 
// Math pour calculer la racine carrée d'un nombre réel : 
// √Δ se traduira alors par : Math.Sqrt(delta)
// ===========================================================================

using System;

namespace AlgorithmesDeCalcul
{
	class ResolutionEquationSecondDegreDansR
	{
		static void Main(string[] args)
		{

			double a, b, c, delta;
			double x, x1, x2;

			Console.Write("Entrer une valeur pour a : ");
			a = Double.Parse(Console.ReadLine());

			Console.Write("Entrer une valeur pour b : ");
			b = Double.Parse(Console.ReadLine());

			Console.Write("Entrer une valeur pour c : ");
			c = Double.Parse(Console.ReadLine());

			if (a == 0)
			{
				if (b == 0)
				{
					if (c == 0)
					{
						Console.WriteLine("tout reel est solution");
					}
					else
					{ // c != 0
						Console.WriteLine("Pas de solution");
					}
				}
				else
				{ // b != 0
					x = -c / b;
					Console.WriteLine("la solution est " + x);
				}
			}
			else
			{ // a != 0
				delta = b * b - 4 * a * c;
				if (delta < 0)
				{
					Console.WriteLine("Pas de solution");
				}
				else
				{ // delta >= 0
					x1 = (-b + Math.Sqrt(delta)) / (2 * a);
					x2 = (-b - Math.Sqrt(delta)) / (2 * a);
					Console.WriteLine("2 solutions " + x1 + " et " + x2);
				}
			}
			Console.ReadLine();
		}
	}
}