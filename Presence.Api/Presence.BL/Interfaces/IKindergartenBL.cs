using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL.Classes
{
    public interface IKindergartenBL
    {
        void AddKindergarten(KindergartenDTO kindergarten);
        void DeleteKindergarten(int id);
        List<KindergartenDTO> GetAllKindergartens();
        KindergartenDTO GetKindergartenById(int id);
        void UpdateKindergarten(KindergartenDTO kindergarten, int id);
    }
}