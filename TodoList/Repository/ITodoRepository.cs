using TodoList.Models;

namespace TodoList.Repository;

public interface ITodoRepository : IRepository<Todo,Guid>
{
    List<Todo> GetAllByTitleContains(string title); 
}
