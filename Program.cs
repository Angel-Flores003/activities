using System;
using LibreriaEjercicios;
//Pre: L'usuari ha d'introduir números naturals
namespace Ejercicios
{
    public class ValidPosNoCeien //Ej 4, valida si un nombre és positiu i menor que 100
    {
        public static void Main()
        {
            const string PRIME = "Introdueix un número positiu:";
            const string POS = "El número introduït és positiu i menor que 100";
            const string NOTPOS = "El número introduït és negatiu o més gran o igual que 100";
            const string ERROR = "Error de programa";
            int num;
            bool neg = false;
            try
            {
                Console.WriteLine(PRIME);
                num = Convert.ToInt32(Console.ReadLine());
                neg = Libreria.ValidPosAndNoCien(num);
                if (neg == false)
                {
                    Console.WriteLine(NOTPOS);
                }
                else
                {
                    Console.WriteLine(POS);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(ERROR);
            }
        }
    }
}
//El programa indica si el número introduït és negatiu o més gran o igual que 100