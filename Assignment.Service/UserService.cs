using Assignment.DAL;
using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service
{
    public class UserService
    {
        private readonly IUserRepository repository;
        public UserService()
        {
            repository = new UserRepository();
        }

        public Task<IList<User>> GetUsers(int userId)
        {
            return repository.GetUsersById(userId);
        }
        public Task<bool> LoginUser(string userName, string password)
        {
            return repository.LoginUser(userName, password);
        }
    }
}
