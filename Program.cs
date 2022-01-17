using System;
using Projeto_Series.Classes;

namespace Projeto_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie serie = new Serie(1, Enum.Genero.Comedia, "Série braba, assiste ai", 2021, 158, 6);

            System.Console.WriteLine("Printando uma série");    
            System.Console.WriteLine(serie);
            System.Console.WriteLine();

            Anime anime = new Anime(2, Enum.Genero.Aventura, "CONFIA", 2007, Enum.Tipologia_Anime.Shonen, 600, 9);
            System.Console.WriteLine("Pritando um anime");
            System.Console.WriteLine(anime);
            System.Console.WriteLine();

            Filme filme = new Filme(3, Enum.Genero.Acao, "Praticamente é 'My name is James bond'", 2009, new TimeSpan(1, 48, 53));
            System.Console.WriteLine("Printando um filme");
            System.Console.WriteLine(filme);
            System.Console.WriteLine();
        }
    }
}
