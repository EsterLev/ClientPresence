using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL.Classes
{
    public class KindergartenPresenceDAL : IKindergartenPresenceDAL
    {
        private readonly PRESENCEContext _context;
        public KindergartenPresenceDAL(PRESENCEContext context)
        {
            _context = context;
        }
        public List<KindergartenPresence> GetAllKindergartenPresences()
        {
            return _context.KindergartenPresences.ToList();
        }

        public KindergartenPresence GetKindergartenPresenceById(int id)
        {
            KindergartenPresence kindergartenPresence = _context.KindergartenPresences.FirstOrDefault(p => p.Id == id);
            return kindergartenPresence;
        }
        public void AddKindergartenPresence(KindergartenPresence kindergartenPresence)
        {
            _context.KindergartenPresences.Add(kindergartenPresence);
            _context.SaveChanges();
        }
        public void UpdateKindergartenPresence(KindergartenPresence kindergartenPresence, int id)
        {

            KindergartenPresence currentKindergartenPresence = _context.KindergartenPresences.Where(x => x.Id == id).FirstOrDefault();
            //יש לזכור למחוק
            kindergartenPresence.Id = id;
            _context.Entry(currentKindergartenPresence).CurrentValues.SetValues(kindergartenPresence);
            _context.SaveChanges();

        }

        public void DeleteKindergartenPresence(int id)
        {
            KindergartenPresence kindergartenPresence = _context.KindergartenPresences.Where(x => x.Id == id).FirstOrDefault();
            _context.KindergartenPresences.Remove(kindergartenPresence);
            _context.SaveChanges();
        }
    }
}
