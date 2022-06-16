using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DTO.Models
{
    public partial class ActingTeacherDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int KindergartenId { get; set; }
        public int? DayByWeek { get; set; }
    }
}
