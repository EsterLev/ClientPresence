using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL.Classes
{
    public class KindergartenDAL : IKindergartenDAL
    {
        private readonly PRESENCEContext _context;
        public KindergartenDAL(PRESENCEContext c)
        {
            this._context = c;
        }
        public List<Kindergarten> GetAllKindergarten()
        {
            return _context.Kindergartens.ToList();
        }

        public Kindergarten GetKindergartenById(int id)
        {
            Kindergarten kindergarten = _context.Kindergartens.FirstOrDefault(p => p.Id == id);
            return kindergarten;
        }
        public void AddKindergarten(Kindergarten kindergarten)
        {
            _context.Kindergartens.Add(kindergarten);
            _context.SaveChanges();
        }
        public void UpdateKindergarten(Kindergarten kindergarten, int id)
        {

            Kindergarten currentKindergarten = _context.Kindergartens.Where(x => x.Id == id).FirstOrDefault();
            //יש לזכור למחוק
            kindergarten.Id = id;
            _context.Entry(currentKindergarten).CurrentValues.SetValues(kindergarten);
            _context.SaveChanges();

        }
        public void DeleteKindergarten(int id)
        {
            Kindergarten kindergarten = _context.Kindergartens.Where(x => x.Id == id).FirstOrDefault();
            User user = _context.Users.Where(x => x.Id == kindergarten.TeacherId).FirstOrDefault();
            _context.Kindergartens.Remove(kindergarten);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
