using System;
using System.Collections.Generic;

#nullable disable

namespace Presence.DTO.Models
{
    public partial class ParentDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ConnectionId { get; set; }
    }
}
