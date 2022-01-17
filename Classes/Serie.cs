using Projeto_Series.Enum;

namespace Projeto_Series.Classes
{
    public class Serie : Basic_Entity
    {
        private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}
        private Genero genero { get; set; }

        public Serie(int id, Genero genero, string descricao, int ano){
            this.id = id;
            this.genero = genero;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string result = "";
            result += "ID: " + this.id + "\n";
            result += "Genero: " + this.genero + "\n";
            result += "Descrição: " + this.Descricao + "\n";
            result += "Ano de lançamento: " + this.Ano + "\n";
            result += "Excluído: " + this.Excluido;

            return result;
        }
    }
}