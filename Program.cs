using System;
using LibreriaEjercicios;
//Pre: L'usuari ha d'introduir números naturals
namespace MyProject
{
    public class IntroMulti //Ej 14, retorna el màxim i mínim de dos valors enters introduïts per tecla
    {
        public static void Main()
        {
            const string PRIME = "Intropdueix el primer número per fer la comparació ";
            const string OTHER = "Introdueix l'altre número";
            const string MAX = "El valor màxim és: ";
            const string MIN = "El valor mínim és: ";
            const string Error = "Error de programa";
            int num1, num2;
            try
            {
                Console.WriteLine(PRIME);
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(OTHER);
                num2 = Convert.ToInt32(Console.ReadLine());
                Libreria.MaxAndMin(ref num1, ref num2);
                Console.WriteLine(MAX + num1);
                Console.WriteLine(MIN + num2);
            }
            catch (Exception)
            {
                Console.WriteLine(Error);
            }
        }
    }
}
//El programa retorna el valor màxim i el mínim de dos valors introduïts per teclat