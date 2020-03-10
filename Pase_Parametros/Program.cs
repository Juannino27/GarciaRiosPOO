using System;

namespace Pase_Parametros
{//Creacion clase Numero
   class Numero
   {//Variable tipo valor
       public void Potencia(int p)
       {
           p = p * p * p;
       }
       
   }
   //Creacion clase Concursante
   class Concursante
   {//Variable tipo valor
       public string nombre;

       public Concursante()
       {
           nombre = "Juan";
       }
   }
   
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            //Objeto nuevo de clase Numero y Concursante
            Numero nuevo = new Numero();
            Concursante F = new Concursante();
            //Pase de parametros tipo valor
            nuevo.Potencia(a);
            Console.WriteLine(a);
            Console.WriteLine("{0} {1}", "Sigue Intentando:", F.nombre);

        }
    }
}
