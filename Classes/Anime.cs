using Projeto_Series.Enum;

namespace Projeto_Series.Classes
{
    public class Anime : Membro_Catalogo
    {
        public Tipologia_Anime Tipologia { get; set; }
        public int Numero_episodios { get; set; }
        public int Numero_temporadas { get; set; }

        public Anime(int id, Genero genero, string descricao, int ano, Tipologia_Anime tipo, int n_ep, int n_temp){
            this.id = id;
            this.genero = genero;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
            this.Tipologia = tipo;
            this.Numero_episodios = n_ep;
            this.Numero_temporadas = n_temp;
        }

        public override string ToString()
        {
            string result = "";
            result += "ID: " + this.id + "\n";
            result += "Genero: " + this.genero + "\n";
            result += "Descrição: " + this.Descricao + "\n";
            result += "Ano de lançamento: " + this.Ano + "\n";
            result += "Excluído: " + this.Excluido + "\n";
            result += "Tipologia do anime: " + this.Tipologia + "\n";
            result += "Número de episódios: " + this.Numero_episodios + "\n";
            result += "Número de temporadas: " + this.Numero_temporadas;

            return result;
        }
    }
}