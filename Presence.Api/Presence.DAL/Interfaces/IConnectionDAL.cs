using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL.Classes
{
    public interface IConnectionDAL
    {
        List<Connection> GetAllConnections();
        Connection GetConnectionById(int id);
    }
}