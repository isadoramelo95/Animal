using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IAnimalRepository<TEntity> where TEntity : class
    {
        List<TEntity> ObterTodos();

        TEntity Obter(TEntity entity);

        void Inserir(TEntity entity);

        void Atualizar(TEntity entity);

        void Excluir(TEntity entity);
    }

}

