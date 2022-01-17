using System;
using Projeto_Series.Classes;

namespace Projeto_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie serie = new Serie(1, Enum.Genero.Comedia, "Série braba, assiste ai", 2021);

            System.Console.WriteLine(serie);
        }
    }
}
