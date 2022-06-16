using Presence.DAL.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DTO.Models
{
    public partial class StudentsPresenceDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int KindergartenPresenceId { get; set; }
        public int TypePresence { get; set; }
    }
}
