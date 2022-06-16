using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL.Classes
{
    public interface IPresenceTypeDAL
    {
        List<PresenceType> GetAllPresenceTypes();
        PresenceType GetPresenceTypeById(int id);
    }
}