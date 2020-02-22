using System;

namespace Peliculas
{class Pelicula 
{
    private string Titulo;
    private int Año;
    private string Pais;
    private string Director;

    public Pelicula(string Titulo, int Año, string Pais, string Director)
    {
        this.Titulo = Titulo;
        this.Año = Año;
        this.Pais = Pais;
        this.Director = Director;
    }
    // Se crea el Metodo imprime
    public void imprime()
    {
        Console.WriteLine("{0}({1}, {2}, {3})", this.Titulo, this.Año, this.Pais, this.Director);
    }
}

    class Program
    {
        static void Main(string[] args)
        {//Objetos clase Pelicula
            Pelicula Peli1 = new Pelicula("Titanic", 1994, "Estados Unidos", "James Cameron");
            Pelicula Peli2 = new Pelicula("Black Panther", 2018, "Estados Unidos", "Ryan Coogler");
            //  Se llama al metodo imprime
            Peli1.imprime();
            Peli2.imprime();
        }
    }
}


