using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DTO.Models
{
    public partial class DelaySchoolBusDTO
    {
        public int Id { get; set; }
        public int SchoolBusId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan DelayTime { get; set; }
        public int EscortId { get; set; }
    }
}
