using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL.Classes
{
    public interface IKindergartenPresenceBL
    {
        void AddKindergartenPresence(KindergartenPresenceDTO kindergartenPresence);
        void DeleteKindergartenPresence(int id);
        List<KindergartenPresenceDTO> GetAllKindergartenPresences();
        KindergartenPresenceDTO GetKindergartenPresenceById(int id);
        void UpdateKindergartenPresence(KindergartenPresenceDTO kindergartenPresence, int id);
    }
}