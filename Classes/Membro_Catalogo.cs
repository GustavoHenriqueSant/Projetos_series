using Projeto_Series.Enum;

namespace Projeto_Series.Classes
{
    public abstract class Membro_Catalogo : Basic_Entity
    {
        public Categoria categoria {get; protected set;}
        public Genero genero {get; protected set;}
        public string Titulo { get; protected set; }
		public string Descricao { get; protected set; }
		public int Ano { get; protected set; }
        public bool Excluido {get; protected set;}


    }
}