using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class PresenceType
    {
        public PresenceType()
        {
            StudentsPresences = new HashSet<StudentsPresence>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<StudentsPresence> StudentsPresences { get; set; }
    }
}
