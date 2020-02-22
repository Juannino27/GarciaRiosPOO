using System;
using System.Collections.Generic;
namespace Peliculas
{class Pelicula
    {
        public string Titulo;
        
        //Metodo imprime
        public void imprime()
        {
            Console.WriteLine(Titulo);
        }
        public Pelicula(string t)
        {
            Titulo = t;
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
           Pelicula Peli = new Pelicula("Titanic");
           Peli.Titulo = "Titanic";
           List<Pelicula> Pelis = new List<Pelicula>();
           Pelis.Add(Peli);
           Pelis.Add(new Pelicula("Scarface"));
           Pelis.Add(new Pelicula("El Rey Leon")); 
           Pelis.Add(new Pelicula("Shrek"));
           Pelis.Add(new Pelicula("Sonic"));

           //Ciclo foreach para el metodo imprimir
           foreach(Pelicula P in Pelis)
           {
               P.imprime();
           }
            
        }
    }
}    