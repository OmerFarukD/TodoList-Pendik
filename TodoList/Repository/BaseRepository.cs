using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Repository
{
    public abstract class BaseRepository
    {

        List<Todo> todos = new List<Todo>();
        List<User> users = new List<User>();



        public List<User> Users()
        {
            return users;
        }

        public List<Todo> Todos()
        {
            return todos;
        }
    }
}
