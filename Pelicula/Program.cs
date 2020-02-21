using System;

namespace Pelicula
{class Pelicula
{
    public string Titulo;
    public int año;
    public string Pais;
    public string Director;
}

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula Peli1 = new Pelicula();
            Pelicula Peli2 = new Pelicula();

            Peli1.Titulo = "Titanic";
            Peli1.año = 1997;
            Peli2.Titulo = "Black Panter";
            Peli2.año = 2018;
            
            Console.WriteLine(Peli1.Titulo);
            Console.WriteLine(Peli1.año);
            Console.WriteLine(Peli2.Titulo);
            Console.WriteLine(Peli2.año);

        }
    }
}
