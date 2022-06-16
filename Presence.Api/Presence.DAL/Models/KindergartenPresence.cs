using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class KindergartenPresence
    {
        public KindergartenPresence()
        {
            StudentsPresences = new HashSet<StudentsPresence>();
        }

        public int Id { get; set; }
        public int KindergartenId { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public virtual Kindergarten Kindergarten { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<StudentsPresence> StudentsPresences { get; set; }
    }
}
