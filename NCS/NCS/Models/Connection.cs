using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCS.Models
{
    public class Connection
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ConnectionType")]
        public int ConnectionTypeId { get; set; }
        public ConnectionType ConnectionType { get; set; }
        public string ConnectionName { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<PlanDetail> PlanDetails { get; set; }



    }
}