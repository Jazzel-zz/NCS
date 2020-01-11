using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NCS.Models;

namespace NCS.Models
{
    public class ConnectionType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<Connection> Connections { get; set; }

    }
}