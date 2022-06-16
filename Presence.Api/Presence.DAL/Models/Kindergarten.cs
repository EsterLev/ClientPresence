using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class Kindergarten
    {
        public Kindergarten()
        {
            ActingTeachers = new HashSet<ActingTeacher>();
            Birthdays = new HashSet<Birthday>();
            KindergartenPresences = new HashSet<KindergartenPresence>();
            Reminders = new HashSet<Reminder>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int TeacherId { get; set; }

        public virtual User Teacher { get; set; }
        public virtual ICollection<ActingTeacher> ActingTeachers { get; set; }
        public virtual ICollection<Birthday> Birthdays { get; set; }
        public virtual ICollection<KindergartenPresence> KindergartenPresences { get; set; }
        public virtual ICollection<Reminder> Reminders { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
