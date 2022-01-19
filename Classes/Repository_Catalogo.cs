using System.Collections.Generic;
using Projeto_Series.Interfaces;

namespace Projeto_Series.Classes
{
    public class Repository_Catalogo : IRepository<Membro_Catalogo>
    {
        private List<Membro_Catalogo> lista = new List<Membro_Catalogo>();

        public void atualizar(int id, Membro_Catalogo novo)
        {
            this.lista[id] = novo;
        }

        public void excluir(int id)
        {
            lista[id].exclusao();
        }

        public Membro_Catalogo getByID(int id)
        {
            return lista[id];
        }

        public void Inserir(Membro_Catalogo novo)
        {
            this.lista.Add(novo);
        }

        public List<Membro_Catalogo> listar()
        {
            return this.lista;
        }

        public int prox_ID()
        {
            return this.lista.Count;
        }
    }
}