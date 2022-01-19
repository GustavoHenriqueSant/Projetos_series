using System;
using System.Collections.Generic;
using System.Linq;
using Projeto_Series.Classes;
using Projeto_Series.Enum;

namespace Projeto_Series
{
    class Program
    {
        static Repository_Catalogo catalogo = new Repository_Catalogo();
        static void Main(string[] args)
        {
            System.Console.WriteLine("#=====================================================#");
            System.Console.WriteLine("#            BEM-VINDO AO PREOJETO SERIES             #");
            int opcao = opcoesUser();

            while(opcao != 9){
                switch(opcao){
                    case 1:
                        listar_Catalogo();
                        break;
                    case 2:
                        listar_filmes();
                        break;
                    case 3:
                        listar_series();
                        break;
                    case 4:
                        listar_anime();
                        break;
                    case 5:
                        inserir_membro();
                        break;
                    case 6:
                        atualizar();
                        break;
                    case 7:
                        excluir();
                        break;
                    case 8:
                        visualizar();
                        break;
                }
                opcao = opcoesUser();
            }
            
            // Serie serie = new Serie(catalogo.prox_ID(), Enum.Genero.Comedia, "Série braba, assiste ai", 2021, 158, 6);

            // // System.Console.WriteLine("Printando uma série");    
            // // System.Console.WriteLine(serie);
            // // System.Console.WriteLine();

            // Anime anime = new Anime(catalogo.prox_ID(), Enum.Genero.Aventura, "CONFIA", 2007, Enum.Tipologia_Anime.Shonen, 600, 9);
            // // System.Console.WriteLine("Pritando um anime");
            // // System.Console.WriteLine(anime);
            // // System.Console.WriteLine();

            // Filme filme = new Filme(catalogo.prox_ID(), Enum.Genero.Acao, "Praticamente é 'My name is James bond'", 2009, new TimeSpan(1, 48, 53));
            // // System.Console.WriteLine("Printando um filme");
            // // System.Console.WriteLine(filme);
            // // System.Console.WriteLine();

            // catalogo.Inserir(serie);
            // catalogo.Inserir(anime);

            // atualizar(1);
        }

        static int opcoesUser(){
            System.Console.WriteLine("#=====================================================#");
            System.Console.WriteLine("#  01 - Listar catálogo                               #");
            System.Console.WriteLine("#  02 - Listar filmes                                 #");
            System.Console.WriteLine("#  03 - Listar Séries                                 #");
            System.Console.WriteLine("#  04 - Listar Animes                                 #");
            System.Console.WriteLine("#  05 - Inserir uma nova entidade ao catálogo         #");
            System.Console.WriteLine("#  06 - Atualizar algum membro do catálogo            #");
            System.Console.WriteLine("#  07 - Excluir alguma entidade do catálogo           #");
            System.Console.WriteLine("#  08 - Visualizar algum membro do catálogo           #");
            System.Console.WriteLine("#  09 - Sair                                          #");
            System.Console.WriteLine("#=====================================================#");
        
            return int.Parse(System.Console.ReadLine());
        }

        static void listar_Catalogo(){
            List<Membro_Catalogo> lista_aux = catalogo.listar();

            System.Console.WriteLine("#=====================================================#");
            System.Console.WriteLine("#      ESTE É O NOSSO CATÁLOGO, ESPERO QUE GOSTE      #");
            System.Console.WriteLine("#=====================================================#");
            foreach (var item in lista_aux)
            {
                System.Console.WriteLine(item);
                System.Console.WriteLine("# ");
            }

        }

        static void listar_filmes(){
            List<Membro_Catalogo> filmes = catalogo.listar().FindAll(x => x.categoria == Categoria.Filme).ToList();

            System.Console.WriteLine("#=====================================================#");
            System.Console.WriteLine("#    ESTES SÃO OS NOSSOS FILMES, ESPERO QUE GOSTE     #");
            System.Console.WriteLine("#=====================================================#");
            foreach (var item in filmes)
            {
                System.Console.WriteLine(item);
                System.Console.WriteLine("# ");
            }
        }

        static void listar_series(){
            List<Membro_Catalogo> series = catalogo.listar().FindAll(x => x.categoria == Categoria.Serie).ToList();

            System.Console.WriteLine("#=====================================================#");
            System.Console.WriteLine("#    ESTAS SÃO AS NOSSAS SÉRIES, ESPERO QUE GOSTE     #");
            System.Console.WriteLine("#=====================================================#");
            foreach (var item in series)
            {
                System.Console.WriteLine(item);
                System.Console.WriteLine("# ");
            }
        }

        static void listar_anime(){
            List<Membro_Catalogo> animes = catalogo.listar().FindAll(x => x.categoria == Categoria.Anime).ToList();

            System.Console.WriteLine("#=====================================================#");
            System.Console.WriteLine("#    ESTES SÃO OS NOSSOS ANIMES, ESPERO QUE GOSTE     #");
            System.Console.WriteLine("#=====================================================#");
            foreach (var item in animes)
            {
                System.Console.WriteLine(item);
                System.Console.WriteLine("# ");
            }
        }

        static void inserir_membro(){
            System.Console.WriteLine("#=====================================================#");
            System.Console.WriteLine("# Em qual categoria deseja inserir ?                  #");
            System.Console.WriteLine("#=====================================================#");
            foreach(int i in System.Enum.GetValues(typeof(Categoria))){
                System.Console.WriteLine("# {0} - {1}                                           #", i, System.Enum.GetName(typeof(Categoria), i));
            }
            System.Console.WriteLine("#=====================================================#");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                    catalogo.Inserir(inserir_filme());
                    break;
                case 2:
                    catalogo.Inserir(inserir_serie());
                    break;
                case 3:
                    catalogo.Inserir(inserir_anime());
                    break;
            }
        }

        static Serie inserir_serie(){
            System.Console.WriteLine("#=====================================================#");
            System.Console.WriteLine("# Digite o gênero entre as opções abaixo:             #");
            System.Console.WriteLine("#=====================================================#");
            foreach (int i in System.Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("# {0}-{1}                                              ", i, System.Enum.GetName(typeof(Genero), i));
			}
            System.Console.WriteLine("#=====================================================#");

			int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o Título da Série:                           #");
            System.Console.WriteLine("#=====================================================#");
			string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o Ano de Início da Série:                    #");
            System.Console.WriteLine("#=====================================================#");
			int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite a Descrição da Série:                        #");
            System.Console.WriteLine("#=====================================================#");
			string entradaDescricao = Console.ReadLine();

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o número de episódios da Série:              #");
            System.Console.WriteLine("#=====================================================#");
			int n_ep = int.Parse(Console.ReadLine());

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite número de temporadas da Série:               #");
            System.Console.WriteLine("#=====================================================#");
			int n_temp = int.Parse(Console.ReadLine());

            return new Serie(catalogo.prox_ID(), entradaTitulo, (Genero)entradaGenero, entradaDescricao, entradaAno, n_ep, n_temp, Categoria.Serie);
        }

        static Filme inserir_filme(){
            System.Console.WriteLine("#=====================================================#");
            System.Console.WriteLine("# Digite o gênero entre as opções acima:              #");
            System.Console.WriteLine("#=====================================================#");
            foreach (int i in System.Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("# {0}-{1}                                              ", i, System.Enum.GetName(typeof(Genero), i));
			}
            System.Console.WriteLine("#=====================================================#");
			int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o Título do filme:                           #");
            System.Console.WriteLine("#=====================================================#");
			string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o Ano de Início do filme:                    #");
            System.Console.WriteLine("#=====================================================#");
			int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite a Descrição do filme:                        #");
            System.Console.WriteLine("#=====================================================#");
			string entradaDescricao = Console.ReadLine();

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite a diração do filme no fortato H:M:S:         #");
            System.Console.WriteLine("#=====================================================#");
			int [] tempo = Console.ReadLine().Split(":").Select(x => int.Parse(x)).ToArray();

            return new Filme(catalogo.prox_ID(), entradaTitulo, (Genero)entradaGenero, entradaDescricao, entradaAno, new TimeSpan(tempo[0], tempo[1], tempo[2]), Categoria.Filme);
        }

        static Anime inserir_anime(){
            System.Console.WriteLine("#=====================================================#");
            System.Console.WriteLine("# Digite o gênero entre as opções acima:              #");
            System.Console.WriteLine("#=====================================================#");
			foreach (int i in System.Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("# {0}-{1}                                              ", i, System.Enum.GetName(typeof(Genero), i));
			}
            System.Console.WriteLine("#=====================================================#");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o Título do anime:                           #");
            System.Console.WriteLine("#=====================================================#");
			string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o Ano de Início do anime:                    #");
            System.Console.WriteLine("#=====================================================#");
			int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite a Descrição do anime:                        #");
            System.Console.WriteLine("#=====================================================#");
			string entradaDescricao = Console.ReadLine();

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite a tipologia do anime dada as opções acima:   #");
            System.Console.WriteLine("#=====================================================#");
            foreach (int i in System.Enum.GetValues(typeof(Tipologia_Anime)))
			{
				Console.WriteLine("# {0}-{1}                                              ", i, System.Enum.GetName(typeof(Tipologia_Anime), i));
			}
            System.Console.WriteLine("#=====================================================#");
			int entradaTipologia = int.Parse(Console.ReadLine());

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o número de episódios do anime:              #");
            System.Console.WriteLine("#=====================================================#");
			int entrada_ep = int.Parse(Console.ReadLine());

            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o número de temporadas do anime:             #");
            System.Console.WriteLine("#=====================================================#");
			int entrada_temp = int.Parse(Console.ReadLine());

            return new Anime(catalogo.prox_ID(), entradaTitulo, (Genero)entradaGenero, entradaDescricao, entradaAno, (Tipologia_Anime)entradaTipologia, entrada_ep, entrada_temp, Categoria.Anime);        
        }

        static void atualizar(){
            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o id do membro que deseja atualizar:         #");
            System.Console.WriteLine("#=====================================================#");
            int id = int.Parse(Console.ReadLine());

            switch((catalogo.getByID(id)).categoria){
                case Categoria.Filme:
                    Filme filme_atualizado = inserir_filme();
                    filme_atualizado.set_ID(id);
                    catalogo.atualizar(id, filme_atualizado);
                    break;
                case Categoria.Serie:
                    Serie serie_atualizado = inserir_serie();
                    serie_atualizado.set_ID(id);
                    catalogo.atualizar(id, serie_atualizado);
                    break;
                case Categoria.Anime:
                    Anime anime_atualizado = inserir_anime();
                    anime_atualizado.set_ID(id);
                    catalogo.atualizar(id, anime_atualizado);
                    break;
            }
        }

        static void excluir(){
            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o id do membro que deseja excluir  :         #");
            System.Console.WriteLine("#=====================================================#");
            catalogo.excluir(int.Parse(Console.ReadLine()));
        }

        static void visualizar(){
            System.Console.WriteLine("#=====================================================#");
			System.Console.WriteLine("# Digite o id do membro que deseja visuallizar:       #");
            System.Console.WriteLine("#=====================================================#");
            System.Console.WriteLine(catalogo.getByID(int.Parse(Console.ReadLine())));
        }
    }
}
