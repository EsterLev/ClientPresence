using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DTO.Models
{
    public partial class UserDTO
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public string UserName { get; set; }
    }
}
