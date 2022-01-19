using Projeto_Series.Enum;

namespace Projeto_Series.Classes
{
    public class Serie : Membro_Catalogo
    {
        private int numero_episodios { get; set; }
        private int numero_temporadas { get; set; }

        public Serie(int id, string titulo, Genero genero, string descricao, int ano, int n_ep, int n_temp,  Categoria categoria){
            this.Titulo = titulo;
            this.id = id;
            this.genero = genero;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
            this.numero_episodios = n_ep;
            this.numero_temporadas = n_temp;
            this.categoria = categoria;
        }

        public override string ToString()
        {
            string result = "# Título: " + this.Titulo + "\n";
            result += "# ID: " + this.id + "\n";
            result += "# Genero: " + this.genero + "\n";
            result += "# Descrição: " + this.Descricao + "\n";
            result += "# Ano de lançamento: " + this.Ano + "\n";
            result += "# Excluído: " + this.Excluido + "\n";
            result += "# Número de episódios: " + this.numero_episodios + "\n";
            result += "# Número de temporadas: " + this.numero_temporadas;

            return result;
        }
    }
}