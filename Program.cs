using System;
using LibreriaEjercicios;
//Pre: L'usuari ha d'introduir números naturals
namespace MyProject
{
    public class IntroMulti //Ej 13, llegeix un nombre en minuts i el canvia a segons 
    {
        public static void Main()
        {
            const string PRIME = "Intropdueix un número per fer la conversió de minuts a segons ";
            const string Error = "Error de programa";
            int num;
            try
            {
                Console.WriteLine(PRIME);
                num = Convert.ToInt32(Console.ReadLine());
                Libreria.ChangeSeconds(ref num);
                Console.WriteLine(num + " segons");
            }
            catch (Exception)
            {
                Console.WriteLine(Error);
            }
        }
    }
}
//El programa retorna la conversió dels minuts a segons