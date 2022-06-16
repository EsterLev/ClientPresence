using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class Parent
    {
        public Parent()
        {
            StudentFathers = new HashSet<Student>();
            StudentMothers = new HashSet<Student>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int ConnectionId { get; set; }

        public virtual Connection Connection { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Student> StudentFathers { get; set; }
        public virtual ICollection<Student> StudentMothers { get; set; }
    }
}
