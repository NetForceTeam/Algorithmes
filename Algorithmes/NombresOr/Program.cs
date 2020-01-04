// ==================================================================
// Précision du calcul ? : 0,00001
// Nombre d'Or = 1.6180328 // rang=14
// ==================================================================

using System;

namespace AlgorithmesDeCalcul
{
    class NombresOr
    {
        static void Main(string[] args)
        {
            int n, Un, Un1 = 2, Un2 = 1;
            double Vn, Vn1 = 2, Eps;
            
            Console.Write("Précision du calcul ? : ");

            //-- précision demandée (exemple 1e-4 ou 1e-2 ou 0,0001, ...) :
            Eps = Double.Parse(Console.ReadLine());

            for (n = 2; ; n++) //n est le rang du terme courant
            {
                Un = Un1 + Un2;
                Vn = (double)Un / (double)Un1;
                if (Math.Abs(Vn - Vn1) <= Eps) break;
                else
                {
                    Un2 = Un1;
                    Un1 = Un;
                    Vn1 = Vn;
                }
            }
            Console.WriteLine("Nombre d'Or = " + Vn + " // rang=" + n);
            Console.ReadLine();
        }
    }
}