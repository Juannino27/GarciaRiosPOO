using System;
using System.Collections.Generic;
namespace Peliculas
{
    class Actor
    {
        public string nomActor;
        public Actor(string nombre)
        {
            nomActor = nombre;
        }
    }
    class Pelicula
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
        //Lista Actores para la clase Actor
       List<Actor> Actores = new List<Actor>();
       public void AgregarActores(Actor nom)
       {
            Actores.Add(nom);
       }
       public void ImprimeActores()
       {
           foreach(Actor a in Actores)
           Console.WriteLine(a.nomActor);
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

           Pelicula Act = new Pelicula("Titanic");
           //Metodo AgregarActores 
           Act.AgregarActores(new Actor("Leonardo Dicaprio"));
           Act.AgregarActores(new Actor("Al Pacino"));
           Act.AgregarActores(new Actor("Matthew Broderick"));
           Act.AgregarActores(new Actor("Eugenio Derbez"));
           Act.AgregarActores(new Actor("Luisito Cominica"));
            //Metodo ImprimeActores
           Act.ImprimeActores();
            
        }
    }
}    