using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL
{
    public interface IUsersTypeDAL
    {
        List<UsersType> GetAllUsersTypes();
        UsersType GetUsersTypesById(int id);
    }
}