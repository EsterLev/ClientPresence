using Presence.DAL.Models;
using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL
{
    public interface IParentBL
    {
        void AddParent(ParentDTO parent);
        void DeleteParent(int id);
        List<ParentDTO> GetAllParents();
        ParentDTO GetParentById(int id);
        void UpdateParent(ParentDTO parent, int id);
    }
}