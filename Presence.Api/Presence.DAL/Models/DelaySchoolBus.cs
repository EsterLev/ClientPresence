using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class DelaySchoolBus
    {
        public int Id { get; set; }
        public int SchoolBusId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan DelayTime { get; set; }
        public int EscortId { get; set; }

        public virtual User Escort { get; set; }
        public virtual SchoolBus SchoolBus { get; set; }
    }
}
