using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL
{
    public class ParentDAL : IParentDAL
    {
        private readonly PRESENCEContext _context;
        public ParentDAL(PRESENCEContext context)
        {
            _context = context;
        }
        public List<Parent> GetAllParents()
        {
            return _context.Parents.ToList();
        }

        public Parent GetParentById(int id)
        {
            Parent parent = _context.Parents.FirstOrDefault(p => p.Id == id);
            return parent;
        }
        public void AddParent(Parent parent)
        {
            _context.Parents.Add(parent);
            _context.SaveChanges();
        }
        public void UpdateParent(Parent parent, int id)
        {

            Parent currentParent = _context.Parents.Where(x => x.Id == id).FirstOrDefault();
            //למחוק!
            parent.Id = id;
            _context.Entry(currentParent).CurrentValues.SetValues(parent);
            _context.SaveChanges();

        }
        public void DeleteParent(int id)
        {
            Parent parent = _context.Parents.Where(x => x.Id == id).FirstOrDefault();
            User user = _context.Users.Where(x => x.Id == parent.UserId).FirstOrDefault();
            _context.Parents.Remove(parent);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

    }
}
