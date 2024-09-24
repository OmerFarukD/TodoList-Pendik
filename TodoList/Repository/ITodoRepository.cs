using TodoList.Models;

namespace TodoList.Repository;

public interface ITodoRepository : IRepository<Todo>
{
    List<Todo> GetAllByTitleContains(string title); 
}
