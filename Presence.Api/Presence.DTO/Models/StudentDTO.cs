using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DTO.Models
{
    public partial class StudentDTO
    {
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
    }
}
