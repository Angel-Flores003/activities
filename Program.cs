using System;
using LibreriaEjercicios;
//Pre: L'usuari ha de un número natural
namespace MyProject
{
    public class ValidTraspas //Ej 10, demana l’any i aquest retorna si és un any de traspàs
    {
        
        public static void Main()
        {
            const string PRIME = "Introdueix l'any: ";
            const string ANYTRAS = "L'any introduït és un any de traspas";
            const string ANYNORM = "L'any introduït no és un any de transpas";
            const string ERROR = "Error de programa";
            int any;
            bool tras = false;
            try
            {
                Console.WriteLine(PRIME);
                any = Convert.ToInt32(Console.ReadLine());
                tras = Libreria.Trasp(any);
                if (tras == false)
                {
                    Console.WriteLine(ANYNORM);
                }
                else
                {
                    Console.WriteLine(ANYTRAS);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(ERROR);
            }
        }
    }
}
//El programa retorna si l'any introduït es de traspas o no