using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class SchoolBus
    {
        public SchoolBus()
        {
            DelaySchoolBuses = new HashSet<DelaySchoolBus>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public int EscortId { get; set; }

        public virtual User Escort { get; set; }
        public virtual ICollection<DelaySchoolBus> DelaySchoolBuses { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
