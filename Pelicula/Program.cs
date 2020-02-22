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
        {   //Declaración de los objetos de la clase Pelicula
            Pelicula Pel1 = new Pelicula();
            Pelicula Pel2 = new Pelicula();
            //Metodo Set y Get para el primer constructor
            Pel1.setTitulo("Titanic");
            Pel1.setAño(1997);
            Pel1.setPais("Estados Unidos");
            Pel1.setDirector("James Cameron");
            Console.WriteLine("{0}({1},{2},{3})", Pel1.getTitulo(), Pel1.getAño(), Pel1.getPais(), Pel1.getDirrector());
            //Metodo Set y Get para el segundo constructor
            Pel2.setTitulo("Black Panther");
            Pel2.setAño(2018);
            Pel2.setPais("Estados Unidos");
            Pel2.setDirector("Ryan Coogler");
            Console.WriteLine("{0}({1},{2},{3})", Pel2.getTitulo(), Pel2.getAño(), Pel2.getPais(), Pel2.getDirrector());
        }
    }
}

