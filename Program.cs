using System;
using LibreriaEjercicios;
//Pre: L'usuari ha d'introduir números naturals
namespace MyProject
{
    public class IntroMulti //Ej 11, demana a l’usuari quants valors vol introduir entre (15, 100), de manera que el programa generi una llista a partir de valors introduïts i retorna la multiplicaci´´o d'aquets
    {
        public static void Main()
        {
            const string NUM = "Quants números naturals vols introduïr? ";
            const string RANG = "Introdueix un número entre 15 i 100: ";
            const string RESULT = "El resultat de la multiplicació és: ";
            const string Error = "Error de programa";
            int num = 0, producte = 1;
            try
            {
                Libreria.ValidNat(NUM, ref num);
                int[] quantitat = new int[num];
                Libreria.Quantitat(num, quantitat, RANG);
                Console.WriteLine(RESULT);
                Libreria.Producte(ref producte, num, quantitat);
                Console.WriteLine(producte);
            }
            catch (Exception)
            {
                Console.WriteLine(Error);
            }
        }
    }
}
//El programa retorna la mul3ltimplicació dels números introduïts per teclat