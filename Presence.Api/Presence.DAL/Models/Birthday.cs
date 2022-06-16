using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class Birthday
    {
        public int Id { get; set; }
        public bool IsPossible { get; set; }
        public int KindergartenId { get; set; }
        public bool? HebrewDate { get; set; }
        public bool? BirthdayPerMonth { get; set; }
        public int? DayByMonth { get; set; }
        public int? DayByWeek { get; set; }
        public int? NumDaysBefore { get; set; }

        public virtual Kindergarten Kindergarten { get; set; }
    }
}
