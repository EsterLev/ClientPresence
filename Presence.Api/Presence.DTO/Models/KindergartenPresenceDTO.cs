using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DTO.Models
{
    public partial class KindergartenPresenceDTO
    {
        public int Id { get; set; }
        public int KindergartenId { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
