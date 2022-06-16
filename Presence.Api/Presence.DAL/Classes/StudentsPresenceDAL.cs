using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL.Classes
{
    public class StudentsPresenceDAL : IStudentsPresenceDAL
    {
        private readonly PRESENCEContext _context;
        public StudentsPresenceDAL(PRESENCEContext context)
        {
            _context = context;
        }
        public List<StudentsPresence> GetAllStudentsPresences()
        {
            return _context.StudentsPresences.ToList();
        }

        public StudentsPresence GetStudentsPresenceById(int id)
        {
            StudentsPresence studentsPresence = _context.StudentsPresences.FirstOrDefault(s => s.Id == id);
            return studentsPresence;
        }
        public void AddStudentsPresence(StudentsPresence studentsPresence)
        {
            _context.StudentsPresences.Add(studentsPresence);
            _context.SaveChanges();
        }
        public void UpdateStudentsPresence(StudentsPresence studentsPresence, int id)
        {
            StudentsPresence currentDelaySchoolBus = _context.StudentsPresences.Where(x => x.Id == id).FirstOrDefault();
            //למחוק!
            studentsPresence.Id = id;
            _context.Entry(currentDelaySchoolBus).CurrentValues.SetValues(studentsPresence);
            _context.SaveChanges();
        }
        public void DeleteStudentsPresence(int id)
        {
            StudentsPresence studentsPresence = _context.StudentsPresences.Where(x => x.Id == id).FirstOrDefault();
            _context.StudentsPresences.Remove(studentsPresence);
            _context.SaveChanges();
        }
    }
}
