using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCS.Models
{
    public class PaymentDetail
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("OrderDetail")]
        public int OrderDetailId { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}