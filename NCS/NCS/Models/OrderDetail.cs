using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCS.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PlanDetail")]
        public int PlanDetailId { get; set; }
        public PlanDetail PlanDetail { get; set; }
        [Required]
        public string CustomerId { get; set; }
        public virtual ApplicationUser Customer { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}