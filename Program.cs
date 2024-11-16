using System;
using LibreriaEjercicios;
//Pre: L'usuari ha de un text i decidir si passar-ho tot a majúscules o a minúscules
namespace MyProject
{
    public class ValorAbolut //Ej 7, reb un text i el retorna a majúscules o a minúscules
    {
        public static void Main()
        {
            const string PRIME = "Introdueix un text per posar-lo en majúscules o en minúscules ";
            const string ELIGE = "Vols pasar-ho tot a majuscules o a minuscules?";
            const string OPTIONONE = "1. Possar-ho tot en majuscules";
            const string OPTIONTWO = "2. Possar-ho tot en minuscules";
            const string UPPER = "El text en majuscules és: ";
            const string LOWER = "El text en minuscules és: ";
            const string ERROR = "Error de programa";
            int option;
            try
            {
                Console.WriteLine(PRIME);
                string Text = Console.ReadLine();
                Console.WriteLine(ELIGE);
                Console.WriteLine(OPTIONONE);
                Console.WriteLine(OPTIONTWO);
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine(UPPER);
                    Text = Libreria.ChangeUpper(Text);
                    Console.WriteLine(Text);
                }
                else if (option == 2)
                {
                    Console.WriteLine(LOWER);
                    Text = Libreria.ChangeLower(Text);
                    Console.WriteLine(Text);
                }
                else
                {
                    Console.WriteLine(ERROR);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(ERROR);
            }
        }
    }
}
//El programa retorna el tex introduït en majúscules o en minúscules