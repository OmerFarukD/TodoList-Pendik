
using TodoList.Models;

namespace TodoList.Repository;

public sealed class TodoRepository : BaseRepository, ITodoRepository
{
    public Todo Add(Todo item)
    {
        throw new NotImplementedException();
    }

    public Todo? Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Todo> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<Todo> GetAllByTitleContains(string title)
    {
        throw new NotImplementedException();
    }

    public Todo? GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Todo? Update(Todo item)
    {
        throw new NotImplementedException();
    }
}
