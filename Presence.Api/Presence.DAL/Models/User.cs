using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class User
    {
        public User()
        {
            ActingTeachers = new HashSet<ActingTeacher>();
            DelaySchoolBuses = new HashSet<DelaySchoolBuse>();
            KindergartenPresences = new HashSet<KindergartenPresence>();
            Kindergartens = new HashSet<Kindergarten>();
            Parents = new HashSet<Parent>();
            SchoolBuses = new HashSet<SchoolBuse>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public string UserName { get; set; }

        public virtual UsersType UserTypeNavigation { get; set; }
        public virtual ICollection<ActingTeacher> ActingTeachers { get; set; }
        public virtual ICollection<DelaySchoolBuse> DelaySchoolBuses { get; set; }
        public virtual ICollection<KindergartenPresence> KindergartenPresences { get; set; }
        public virtual ICollection<Kindergarten> Kindergartens { get; set; }
        public virtual ICollection<Parent> Parents { get; set; }
        public virtual ICollection<SchoolBuse> SchoolBuses { get; set; }
    }
}
