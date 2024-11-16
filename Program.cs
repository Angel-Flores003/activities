using System;
using LibreriaEjercicios;
//Pre: L'usuari ha de introduir números enters
namespace MyProject
{
    public class ValidNaturalTresTried //Ej 5, Valida que numero introducido por teclado sea natural, solo con tres intentos 
    {
        
        public static void Main()
        {
            const string NAT = "El número introduït és natural";
            const string NONAT = "El número introduït no ésnatural i t'has quedat sense intents";
            const string ERROR = "Error de programa";
            int num = 0, intent = 0;
            bool nat = false;
            try
            {
                nat = Libreria.ValidNaturalTries(num, ref intent);
                if (nat == false)
                {
                    Console.WriteLine(NONAT);
                }
                else
                {
                    Console.WriteLine(NAT);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(ERROR);
            }
        }
    }
}
//El programa indica si en 3 intents el número introduït és natural o no 