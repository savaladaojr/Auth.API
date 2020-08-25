using Auth.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Demo.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool SaveChanges();

        IEnumerable<User> GetAll();
        User GetById(int id);

        void Create(User user);

        void Update(User user);

        void Delete(User user);

    }

}