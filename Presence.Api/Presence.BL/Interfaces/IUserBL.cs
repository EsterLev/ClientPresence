using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL
{
    public interface IUserBL
    {
        void AddUser(UserDTO user);
        void DeleteUser(int id);
        List<UserDTO> GetAllUsers();
        UserDTO GetUserById(int id);
        void UpdateUser(UserDTO user, int id);
    }
}