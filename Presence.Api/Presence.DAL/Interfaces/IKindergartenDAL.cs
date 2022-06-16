using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL.Classes
{
    public interface IKindergartenDAL
    {
        void AddKindergarten(Kindergarten kindergarten);
        void DeleteKindergarten(int id);
        List<Kindergarten> GetAllKindergarten();
        Kindergarten GetKindergartenById(int id);
        void UpdateKindergarten(Kindergarten kindergarten, int id);
    }
}