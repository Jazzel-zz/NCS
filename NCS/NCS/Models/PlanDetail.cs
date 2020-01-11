using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCS.Models
{
    public class PlanDetail
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Connection")]
        public int ConnectionId { get; set; }
        public Connection Connection { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}