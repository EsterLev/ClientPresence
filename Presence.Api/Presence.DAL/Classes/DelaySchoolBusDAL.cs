using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL
{
    public class DelaySchoolBusDAL : IDelaySchoolBusDAL
    {
        private readonly PRESENCEContext _context;
        public DelaySchoolBusDAL(PRESENCEContext context)
        {
            _context = context;
        }
        public List<DelaySchoolBuse> GetAllDelaySchoolBuses()
        {
            return _context.DelaySchoolBuses.ToList();
        }

        public DelaySchoolBuse GetDelaySchoolBusById(int id)
        {
            DelaySchoolBuse delaySchoolBus = _context.DelaySchoolBuses.FirstOrDefault(d => d.Id == id);
            return delaySchoolBus;
        }
        public void AddDelaySchoolBus(DelaySchoolBuse delaySchoolBus)
        {
            _context.DelaySchoolBuses.Add(delaySchoolBus);
            _context.SaveChanges();
        }
        public void UpdateDelaySchoolBus(DelaySchoolBuse delaySchoolBus, int id)
        {
            DelaySchoolBuse currentDelaySchoolBus = _context.DelaySchoolBuses.Where(x => x.Id == id).FirstOrDefault();
            //למחוק!
            delaySchoolBus.Id = id;
            _context.Entry(currentDelaySchoolBus).CurrentValues.SetValues(delaySchoolBus);
            _context.SaveChanges();
        }
        public void DeleteDelaySchoolBus(int id)
        {
            DelaySchoolBuse delaySchoolBus = _context.DelaySchoolBuses.Where(x => x.Id == id).FirstOrDefault();
            _context.DelaySchoolBuses.Remove(delaySchoolBus);
            _context.SaveChanges();
        }
    }
}
