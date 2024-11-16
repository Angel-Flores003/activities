using System;
using LibreriaEjercicios;
//Pre: L'usuari ha de un número enter
namespace MyProject
{
    public class ValorAbolut //Ej 6, retorna el valor absolut d'un nombre introduït per teclat
    {
        public static void Main()
        {
            const string PRIME = "Introdueix un número enter: ";
            const string POS = "El valor absolt del número introduït és ";
            const string ERROR = "Error de programa";
            int num;
            try
            {
                Console.WriteLine(PRIME);
                num = Convert.ToInt32(Console.ReadLine());
                Libreria.ValorAbsolut(ref num);
                Console.WriteLine(POS + num);
            }
            catch (Exception)
            {
                Console.WriteLine(ERROR);
            }
        }
    }
}
//El programa retorna el valor absolut del número introduït