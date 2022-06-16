using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentsPresences = new HashSet<StudentsPresence>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Picture { get; set; }
        public bool Gender { get; set; }
        public int? FatherId { get; set; }
        public int? MotherId { get; set; }
        public int KindergartenId { get; set; }
        public int SchoolBusId { get; set; }

        public virtual Parent Father { get; set; }
        public virtual Kindergarten Kindergarten { get; set; }
        public virtual Parent Mother { get; set; }
        public virtual SchoolBuse SchoolBus { get; set; }
        public virtual ICollection<StudentsPresence> StudentsPresences { get; set; }
    }
}
