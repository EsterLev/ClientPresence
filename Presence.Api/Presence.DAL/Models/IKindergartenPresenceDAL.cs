using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL.Classes
{
    public interface IKindergartenPresenceDAL
    {
        void AddKindergartenPresence(KindergartenPresence kindergartenPresence);
        void DeleteKindergartenPresence(int id);
        List<KindergartenPresence> GetAllKindergartenPresences();
        KindergartenPresence GetKindergartenPresenceById(int id);
        void UpdateKindergartenPresence(KindergartenPresence kindergartenPresence, int id);
    }
}