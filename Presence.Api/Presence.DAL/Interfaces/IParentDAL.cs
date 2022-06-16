using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL
{
    public interface IParentDAL
    {
        void AddParent(Parent parent);
        void DeleteParent(int id);
        List<Parent> GetAllParents();
        Parent GetParentById(int id);
        void UpdateParent(Parent parent, int id);
    }
}