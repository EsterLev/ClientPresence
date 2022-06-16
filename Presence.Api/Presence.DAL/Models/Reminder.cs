using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class Reminder
    {
        public int Id { get; set; }
        public TimeSpan Hour { get; set; }
        public int SnoozeDuration { get; set; }
        public int? Daily { get; set; }
        public int? Weekly { get; set; }
        public int? Monthly { get; set; }
        public int KindergartenId { get; set; }

        public virtual Kindergarten Kindergarten { get; set; }
    }
}
