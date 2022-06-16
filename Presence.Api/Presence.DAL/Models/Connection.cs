using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class Connection
    {
        public Connection()
        {
            Parents = new HashSet<Parent>();
        }

        public int Id { get; set; }
        public bool Phone { get; set; }
        public bool Email { get; set; }
        public bool Sms { get; set; }

        public virtual ICollection<Parent> Parents { get; set; }
    }
}
