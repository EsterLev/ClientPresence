using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DTO.Models
{
    public partial class BirthdayDTO
    {
        public int Id { get; set; }
        public bool IsPossible { get; set; }
        public int KindergartenId { get; set; }
        public bool? HebrewDate { get; set; }
        public bool? BirthdayPerMonth { get; set; }
        public int? DayByMonth { get; set; }
        public int? DayByWeek { get; set; }
        public int? NumDaysBefore { get; set; }
    }
}
