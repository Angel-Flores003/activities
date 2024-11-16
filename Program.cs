using System;
using LibreriaEjercicios;
//Pre: L'usuari ha de un número natural
namespace MyProject
{
    public class CalculSumaParellSenar //Ej 9, donat un nombre introduït per teclat calcula quants digits té, suma els dígits amb valor parell i senars

    {


        public static void Main()
        {
            const string PRIME = "Introdueix un número: ";
            const string QUANTITAT = "El número introduït té ";
            const string XIFRA = " xifres";
            const string SUMAPARELLS = "El sumatori dels dígits parells és: ";
            const string SUMASENARS = "El sumatori dels dígits senars és: ";
            const string ERROR = "Error de programa";
            int num, quantitat = 0, parell = 0, senar = 0, residu = 0;
            try
            {
                Console.WriteLine(PRIME);
                num = Convert.ToInt32(Console.ReadLine());
                Libreria.Count(num, ref quantitat, ref parell, ref senar, ref residu);
                Console.Write(QUANTITAT);
                Console.Write(quantitat);
                Console.WriteLine(XIFRA);
                Console.WriteLine(SUMAPARELLS);
                Console.WriteLine(parell);
                Console.WriteLine(SUMASENARS);
                Console.WriteLine(senar);

            }
            catch (Exception)
            {
                Console.WriteLine(ERROR);
            }
        }
    }
}
//El programa retorna la quantita de xifres que té el número introduit i el sumatori de les xifres parrelles i senars