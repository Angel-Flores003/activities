using System;
using LibreriaEjercicios;
//Pre: L'usuari ha d'introduir números naturals
namespace Ejercicios
{
    public class Secondthree//Ej 3, Valida si un nombre és negatiu
    {

        public static void Main()
        {
            const string PRIME = "Introdueix Un número negatiu:";
            const string NEG = "El número introduït és negatiu";
            const string NOTNEG = "El número introduït no és negatiu";
            const string ERROR = "Error de programa";
            int num;
            bool neg = false;
            try
            {
                Console.WriteLine(PRIME);
                num = Convert.ToInt32(Console.ReadLine());
                neg = Libreria.ValidNeg(num);
                if (neg == false)
                {
                    Console.WriteLine(NOTNEG);
                }
                else
                {
                    Console.WriteLine(NEG);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(ERROR);
            }
        }
    }
}
//Post: El programa indica si el número introduït és negatiu o no