using System.Collections.Generic;

namespace Projeto_Series.Interfaces
{
    public interface IRepository<T>
    {
        List<T> listar();
        T getByID(int id);
        void atualizar(int id, T novo);
        void Inserir(T novo);
        void excluir(int id);
        int prox_ID();
          
    }
}