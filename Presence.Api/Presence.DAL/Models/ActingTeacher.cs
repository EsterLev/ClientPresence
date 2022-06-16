using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class ActingTeacher
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int KindergartenId { get; set; }
        public int? DayByWeek { get; set; }

        public virtual Kindergarten Kindergarten { get; set; }
        public virtual User User { get; set; }
    }
}
