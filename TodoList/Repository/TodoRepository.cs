
using TodoList.Models;

namespace TodoList.Repository;

public sealed class TodoRepository : BaseRepository, ITodoRepository
{
    public Todo Add(Todo item)
    {
        Todos().Add(item);
        return item;
    }

    public Todo? Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Todo> GetAll()
    {
        return Todos();
    }

    public List<Todo> GetAllByTitleContains(string title)
    {
        throw new NotImplementedException();
    }

    public Todo? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Todo? Update(Todo item)
    {
        throw new NotImplementedException();
    }
}
