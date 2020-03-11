using System;

namespace Pase_Parametros
{//Creacion clase Numero
   class Numero
   {//Variable tipo valor
       public void Potencia(int p)
       {
           p = p * p * p;
       }
       //Variable tipo in
       public void Potencia(in int p)
       {
       }
       //Variable tipo ref
       public void PotenciaRef(ref int p)
       {
           p = p * p * p;
       }
       //Variable tipo out
       public void Divide(int num1, int num2, out int res)
       {
           res = num1 / num2;
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
   //Clase Cambio, variable tipo referencia
   class Cambio
   {
       static public void Cambiar(Concursante pro)
       {
           pro.nombre = "Mike";
       }
   }
   //Clase Concurso, variable tipo ref
   class Concurso
   {
       static public void Suerte(ref Concursante J)
       {
           J.nombre ="Luis";
       }
   }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 3;
            int c;
           
            //Objeto nuevo de clase Numero y Concursante
            Numero nuevo = new Numero();
            Concursante F = new Concursante();
           
            //Pase de parametros tipo valor
            nuevo.Potencia(a);
            Console.WriteLine(a);
           
            //Pase de parametros tipo in
            nuevo.Potencia(in a);
            Console.WriteLine(a);
           
            //Pase de parametros tipo ref
            nuevo.PotenciaRef(ref a);
            Console.WriteLine(a);
           
            //Pase de parametros tipo out
            nuevo.Divide(a, b, out c);
            Console.WriteLine(c);
            
            //Pase de parametros tipo valor
            Console.WriteLine("{0} {1}", "Sigue Intentando: ",F.nombre);
           
            //Pase de parametros tipo referencia ref
            Cambio.Cambiar(F); 
            Console.WriteLine("{0} {1}", "Sigue intentando: ",F.nombre);
            Concurso.Suerte(ref F);
            Console.WriteLine("{0} {1}", "Felicidades campeón: ",F.nombre);
        }
    }
}
