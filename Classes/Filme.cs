using System;
using Projeto_Series.Enum;

namespace Projeto_Series.Classes
{
    public class Filme : Membro_Catalogo
    {
        public TimeSpan Duracao { get; set; }

        public Filme(int id, Genero genero, string descricao, int ano, TimeSpan duracao){
            this.id = id;
            this.genero = genero;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
            this.Duracao = duracao;
        }

        public override string ToString()
        {
            string result = "";
            result += "ID: " + this.id + "\n";
            result += "Genero: " + this.genero + "\n";
            result += "Descrição: " + this.Descricao + "\n";
            result += "Ano de lançamento: " + this.Ano + "\n";
            result += "Excluído: " + this.Excluido + "\n";
            result += "Duração do filme: " + this.Duracao;

            return result;
        }
    }
}