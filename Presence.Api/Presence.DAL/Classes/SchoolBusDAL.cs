using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL.Classes
{
    public class SchoolBusDAL : ISchoolBusDAL
    {
        private readonly PRESENCEContext _context;
        public SchoolBusDAL(PRESENCEContext context)
        {
            _context = context;
        }
        public List<SchoolBuse> GetAllSchoolBuses()
        {
            return _context.SchoolBuses.ToList();
        }

        public SchoolBuse GetSchoolBusById(int id)
        {
            SchoolBuse schoolBus = _context.SchoolBuses.FirstOrDefault(p => p.Id == id);
            return schoolBus;
        }
        public void AddSchoolBus(SchoolBuse schoolBus)
        {
            _context.SchoolBuses.Add(schoolBus);
            _context.SaveChanges();
        }
        public void UpdateSchoolBus(SchoolBuse schoolBus, int id)
        {

            SchoolBuse currentSchoolBus = _context.SchoolBuses.Where(x => x.Id == id).FirstOrDefault();
            //יש לזכור למחוק
            schoolBus.Id = id;
            _context.Entry(currentSchoolBus).CurrentValues.SetValues(schoolBus);
            _context.SaveChanges();

        }
        public void DeleteSchoolBus(int id)
        {
            SchoolBuse schoolBus = _context.SchoolBuses.Where(x => x.Id == id).FirstOrDefault();
            _context.SchoolBuses.Remove(schoolBus);
            _context.SaveChanges();
        }
    }
}
