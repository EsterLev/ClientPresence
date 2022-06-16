using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DTO.Models
{
    public partial class ConnectionDTO
    {
        public int Id { get; set; }
        public bool Phone { get; set; }
        public bool Email { get; set; }
        public bool Sms { get; set; }
    }
}
