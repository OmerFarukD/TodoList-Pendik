using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Repository
{
    public interface IRepository<TEntity,TId>
        where TEntity : Entity<TId>, new()
    {
        List<TEntity> GetAll();
        TEntity? GetById(TId id);

        TEntity Add(TEntity item);
        TEntity? Update(TEntity item);
        TEntity? Delete(TId id);
    }
}
