using System;
using LibreriaEjercicios;
//Pre: L'usuari ha d'introduir números naturals
namespace Ejercicios
{
    public class ValidarNombreNatural//Ej 1, valida si un numerro es natural 
    {
        public static void Main()
        {
            const string PRIME = "Introdueix un número natural:";
            const string NATURAL = "El número és natural";
            const string NONATURAL = "El número no és natural";
            const string ERROR = "Error de programa";
            int num;
            bool nat;
            try
            {
                Console.WriteLine(PRIME);
                num = Convert.ToInt32(Console.ReadLine());
                nat = Libreria.ValidarNat(num);
                if (!nat)
                {
                    Console.WriteLine(NONATURAL);
                }
                else
                {
                    Console.WriteLine(NATURAL);
                }
                //Console.WriteLine(!nat ? NONATURAL : NATURAL);
            }
            catch (Exception)
            {
                Console.WriteLine(ERROR);
            }
        }
    }
}
//El programa indica si el número introduit és natural o no
