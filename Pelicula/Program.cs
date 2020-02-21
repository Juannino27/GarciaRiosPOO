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
            Pel1.setDirector("James Cameron");
            Pel2.setDirector("Ryan Coogler");
            Pel1.setPais("Estados Unidos");
            Pel2.setPais("Estados Unidos");
            Pel1.setAño(1997);
            Pel2.setAño(2018);
           
            Console.WriteLine("{0}({1}, {2}, {3})", Pel1.getTitulo(), Pel1.getAño(), Pel1.getPais(), Pel1.getDirrector());
            
            
            Console.WriteLine("{0}({1}, {2}, {3})", Pel2.getTitulo(),Pel2.getAño(), Pel2.getPais(), Pel2.getDirrector());
            
        }
    }
