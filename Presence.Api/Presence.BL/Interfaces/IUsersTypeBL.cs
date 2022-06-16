using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL
{
    public interface IUsersTypeBL
    {
        List<UsersTypeDTO> GetAllUsersTypes();
        UsersTypeDTO GetUsersTypeById(int id);
    }
}