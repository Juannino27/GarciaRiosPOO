using System;

namespace Peliculas
{class Pelicula
    {
        private string Titulo, Director, Pais;
        private int año;
        
        public string getTitulo()
        {
            return Titulo;
        }
        public void setTitulo(string t)
        {
            Titulo = t;
        }
        public string getDirrector()
        {
            return Director;
        }
        public void setDirector(string d)
        {
            Director =d;
        }
        public string getPais()
        {
            return Pais;
        }
        public void setPais(string p)
        {
            Pais = p;
        }
        public int getAño()
        {
            return año;
        }
        public void setAño(int a)
        {
            año = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula Pel1 = new Pelicula();
            Pelicula Pel2 = new Pelicula();
            
            Pel1.setTitulo("Titanic");
            Pel2.setTitulo("Black Panther");
            Console.WriteLine(Pel1.getTitulo());
            Console.WriteLine(Pel2.getTitulo());
            Pel1.setAño(1997);
            Pel2.setAño(2018);
            Console.WriteLine(Pel1.getAño());
            Console.WriteLine(Pel2.getAño());
            Pel1.setPais("Estados Unidos");
            Pel2.setPais("Estados Unidos");
            Console.WriteLine(Pel1.getPais());
            Console.WriteLine(Pel2.getPais());
            Pel1.setDirector("James Cameron");
            Pel2.setDirector("Ryan Coogler");


        }
    }
}

