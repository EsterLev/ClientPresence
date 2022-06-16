using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DTO.Models
{
    public partial class SchoolBusDTO
    {
        public int Id { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public int EscortId { get; set; }
    }
}
