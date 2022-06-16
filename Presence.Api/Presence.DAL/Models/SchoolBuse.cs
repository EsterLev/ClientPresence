using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class SchoolBuse
    {
        public SchoolBuse()
        {
            DelaySchoolBuses = new HashSet<DelaySchoolBuse>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public int EscortId { get; set; }

        public virtual User Escort { get; set; }
        public virtual ICollection<DelaySchoolBuse> DelaySchoolBuses { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
