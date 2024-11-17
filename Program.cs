using System;
using LibreriaEjercicios;
//Pre: L'usuari ha d'introduir números naturals
namespace MyProject
{
    public class IntroMulti //Ej 12,  llegeix graus en escala Celsius (CC) i els converteix en graus en escala Fahrenheit (FF)
    {
        public static void Main()
        {
            const string PRIME = "Intropdueix un número per fer la conversió ";
            const string Error = "Error de programa";
            double num;
            try
            {
                Console.WriteLine(PRIME);
                num = Convert.ToInt32(Console.ReadLine());
                Libreria.ChangeGraus(ref num);
                Console.WriteLine(num);
            }
            catch (Exception)
            {
                Console.WriteLine(Error);
            }
        }
    }
}
//El programa retorna la conversió dels graus de (CC) a (FF)