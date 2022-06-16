using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL
{
    public interface IUserDAL
    {
        void AddUser(User user);
        void DeleteUser(int id);
        List<User> GetAllUsers();
        User GetUserById(int id);
        void UpdateUser(User user, int id);
    }
}