using System;
using LibreriaEjercicios;
//Pre: L'usuari ha de introduir números naturals
namespace MyProject
{
    public class ChangeNums //Ej 8, intercanvia dos valors rebuts com argument
    {
        
        public static void Main()
        {
            const string PRIME = "Introdueix el primer número: ";
            const string SECOND = "Introdueix el segón número: ";
            const string CANVIAT = "El números intercanvairs són: ";
            const string ERROR = "Error de programa";
            int a, b;
            try
            {
                Console.WriteLine(PRIME);
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(SECOND);
                b = Convert.ToInt32(Console.ReadLine());
                Libreria.Change(ref a, ref b);
                Console.WriteLine(CANVIAT);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine(ERROR);
            }
        }
    }
}
//El programa canvia el primer número amb el segón