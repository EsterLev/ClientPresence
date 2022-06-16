using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL.Classes
{
    public interface IReminderBL
    {
        void AddReminder(ReminderDTO reminder);
        void DeleteReminder(int id);
        List<ReminderDTO> GetAllReminders();
        ReminderDTO GetReminderById(int id);
        void UpdateReminder(ReminderDTO reminder, int id);
    }
}