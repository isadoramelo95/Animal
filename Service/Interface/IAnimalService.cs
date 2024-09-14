using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IAnimalService<TEntity> where TEntity : class
    {
        TEntity Obter(TEntity entity);
        List<TEntity> ObterTodos(int id);

        void Inserir(TEntity entity);

        void Atualizar(TEntity entity);

        void Remover(TEntity entity);
    }
}
