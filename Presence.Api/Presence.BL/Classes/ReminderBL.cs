using AutoMapper;
using DTO;
using Presence.DAL.Classes;
using Presence.DAL.Models;
using Presence.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presence.BL.Classes
{
    public class ReminderBL : IReminderBL
    {
        private readonly IReminderDAL _reminderDl;
        IMapper mapper;
        public ReminderBL(IReminderDAL reminderDAL)
        {
            _reminderDl = reminderDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<ReminderDTO> GetAllReminders()
        {
            List<Reminder> reminders = _reminderDl.GetAllReninders();
            return mapper.Map<List<Reminder>, List<ReminderDTO>>(reminders);
        }

        public ReminderDTO GetReminderById(int id)
        {
            Reminder reminder = _reminderDl.GetReminderById(id);
            return mapper.Map<Reminder, ReminderDTO>(reminder);
        }
        public void AddReminder(ReminderDTO reminder)
        {
            _reminderDl.AddReminder(mapper.Map<ReminderDTO, Reminder>(reminder));
        }
        public void UpdateReminder(ReminderDTO reminder, int id)
        {
            _reminderDl.UpdateReminder(mapper.Map<ReminderDTO, Reminder>(reminder), id);
        }
        public void DeleteReminder(int id)
        {
            _reminderDl.DeleteReminder(id);
        }
    }
}
