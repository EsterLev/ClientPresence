using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL.Classes
{
    public interface IReminderDAL
    {
        void AddReminder(Reminder reminder);
        void DeleteReminder(int id);
        List<Reminder> GetAllReninders();
        Reminder GetReminderById(int id);
        void UpdateReminder(Reminder reminder, int id);
    }
}