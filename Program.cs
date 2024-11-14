using System;
using LibreriaEjercicios;
//Pre: L'usuari ha d'introduir números naturals
namespace Ejercicios
{
    public class Secondduo//Ej 2, Hace la exponennte de una base, ambas introducidas por teclado
    {
        public static void Main()
        {
            const string BASE = "Introdueix la base:";
            const string EXPO = "Introdueix l'exponent:";
            const string ERROR = "Error de programa";
            const string RESULTAT = "El resultat és: ";
            int b, expo, result;
            try
            {
                Console.WriteLine(BASE);
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(EXPO);
                expo = Convert.ToInt32(Console.ReadLine());
                result = Libreria.BaseExpo(b, expo);
                Console.WriteLine(RESULTAT + result);
            }
            catch (FormatException)
            {
                Console.WriteLine(ERROR);
            }
        }
    }
}
//El programa retorna el resultat d'un exponent introduït per teclat