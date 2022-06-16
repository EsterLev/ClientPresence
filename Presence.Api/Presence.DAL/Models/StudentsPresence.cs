using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class StudentsPresence
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int KindergartenPresenceId { get; set; }
        public int TypePresence { get; set; }

        public virtual KindergartenPresence KindergartenPresence { get; set; }
        public virtual Student Student { get; set; }
        public virtual PresenceType TypePresenceNavigation { get; set; }
    }
}
