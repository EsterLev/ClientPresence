using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL.Classes
{
    public class PresenceTypeDAL : IPresenceTypeDAL
    {
        private readonly PRESENCEContext _context;
        public PresenceTypeDAL(PRESENCEContext context)
        {
            _context = context;
        }
        public List<PresenceType> GetAllPresenceTypes()
        {
            return _context.PresenceTypes.ToList();
        }

        public PresenceType GetPresenceTypeById(int id)
        {
            PresenceType presenceType = _context.PresenceTypes.FirstOrDefault(p => p.Id == id);
            return presenceType;
        }
    }
}
