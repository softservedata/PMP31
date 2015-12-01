using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPZ.DAL
{
    class UsersDAL
    {
        
        public UserDTO GetUserByLogin(string login)
        {
            var user = new UserDTO();
            using (DeviceCategoryContext context = new DeviceCategoryContext())
            {
                user = context.Users.Select(u => new UserDTO
                {
                    id_user = u.id_user,
                    first_name = u.first_name,
                    last_name = u.last_name,
                    email = u.email,
                    phone_number = u.phone_number,
                    login = u.login,
                    password = u.password,
                    id_role = u.id_role
                }).FirstOrDefault(u => (u.login == login));
            }
            return user;

           
        }
        public UserDTO GetUserByPassword(string password)
        {
            var user = new UserDTO();
            using (DeviceCategoryContext context = new DeviceCategoryContext())
            {
                user = context.Users.Select(u => new UserDTO
                {
                    id_user = u.id_user,
                    first_name = u.first_name,
                    last_name = u.last_name,
                    email = u.email,
                    phone_number = u.phone_number,
                    login = u.login,
                    password = u.password,
                    id_role = u.id_role
                }).FirstOrDefault(u => (u.password == password));
            }
            return user;
        }
        
        public void insertUser(UserDTO insertedUser)
        {
            using (DeviceCategoryContext context = new DeviceCategoryContext())
            {
                Users user = new Users();
                user.id_user = insertedUser.id_user;
                user.first_name = insertedUser.first_name;
                user.last_name = insertedUser.last_name;
                user.email = insertedUser.email;
                user.phone_number = insertedUser.phone_number;
                user.login = insertedUser.login;
                user.password = insertedUser.password;
                user.id_role = insertedUser.id_role;
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
