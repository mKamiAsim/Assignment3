using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Model;
using NHibernate;
using NHibernate.Transform;

namespace Assignment.DAL
{
    public class UserRepository : IUserRepository
    {
        public async Task<IList<User>> GetUsersById(int userId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                //var data = await session.GetAsync<User>(userId);      //Using NHibernate get data by Id column
                var query = session.CreateSQLQuery($"SELECT * FROM USERS WHERE USERS.USERID = {userId}");
                return await query.SetResultTransformer(Transformers.AliasToBean<User>()).ListAsync<User>();
            }
        }

        public async Task<bool> LoginUser(string userName, string password)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var result = await session.CreateSQLQuery($"SELECT COUNT(1) FROM USERS WHERE USERS.UserName='{userName}' AND USERS.Password='{password}'").UniqueResultAsync<int>();
                //var result = await query.SetResultTransformer(Transformers.AliasToBean<int>()).UniqueResultAsync<int>();

                return result > 0;
            }
        }
    }
}
