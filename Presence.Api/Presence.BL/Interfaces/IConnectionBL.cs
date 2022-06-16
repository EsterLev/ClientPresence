using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL.Classes
{
    public interface IConnectionBL
    {
        List<ConnectionDTO> GetAllConnections();
        ConnectionDTO GetConnectionById(int id);
    }
}