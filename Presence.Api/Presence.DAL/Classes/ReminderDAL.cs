using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL.Classes
{
    public class ReminderDAL : IReminderDAL
    {
        private readonly PRESENCEContext _context;
        public ReminderDAL(PRESENCEContext context)
        {
            this._context = context;
        }
        public List<Reminder> GetAllReninders()
        {
            return _context.Reminders.ToList();
        }

        public Reminder GetReminderById(int id)
        {
            Reminder remider = _context.Reminders.FirstOrDefault(p => p.Id == id);
            return remider;
        }
        public void AddReminder(Reminder reminder)
        {
            if (!IsValid(reminder))
                throw new Exception("one from the fields: 'daily', 'weekly', 'monthly' must be filled");
            _context.Reminders.Add(reminder);
            _context.SaveChanges();
        }
        public void UpdateReminder(Reminder reminder, int id)
        {
            if (!IsValid(reminder))
                throw new Exception("one from the fields: 'daily', 'weekly', 'monthly' must be filled");
            Reminder currentReminder = _context.Reminders.Where(x => x.Id == id).FirstOrDefault();
            //יש לזכור למחוק
            reminder.Id = id;
            _context.Entry(currentReminder).CurrentValues.SetValues(reminder);
            _context.SaveChanges();

        }
        public void DeleteReminder(int id)
        {
            Reminder reminder = _context.Reminders.Where(x => x.Id == id).FirstOrDefault();
            _context.Reminders.Remove(reminder);
            _context.SaveChanges();
        }
        public bool IsValid(Reminder reminder)
        {
            if ((reminder.Monthly != null && reminder.Weekly == null && reminder.Daily == null) || (reminder.Monthly == null && reminder.Weekly != null && reminder.Daily == null) || (reminder.Monthly == null && reminder.Weekly == null && reminder.Daily != null))
                return true;
            return false;
        }
    }
}
