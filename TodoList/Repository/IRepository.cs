using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Repository
{
    public interface IRepository<TEntity>
        where TEntity : Entity, new()
    {
        List<TEntity> GetAll();
        TEntity? GetById(int id);

        TEntity Add(TEntity item);
        TEntity? Update(TEntity item);
        TEntity? Delete(int id);
    }
}
