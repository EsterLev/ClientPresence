using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.BL.Classes
{
    public interface IPresenceTypeBL
    {
        List<PresenceTypeDTO> GetAllPresenceTypes();
        PresenceTypeDTO GetPresenceTypeById(int id);
    }
}