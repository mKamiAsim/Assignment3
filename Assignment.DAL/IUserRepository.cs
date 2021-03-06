﻿using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DAL
{
    public interface IUserRepository
    {
        Task<IList<User>> GetUsersById(int userId);
        Task<bool> LoginUser(string userName, string password);
    }
}
