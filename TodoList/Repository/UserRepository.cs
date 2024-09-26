using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Repository
{
    public sealed class UserRepository : BaseRepository, IUserRepository
    {
        public User Add(User item)
        {
            throw new NotImplementedException();
        }

        public User? Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User? GetById(long id)
        {
            throw new NotImplementedException();
        }

        public User? Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
