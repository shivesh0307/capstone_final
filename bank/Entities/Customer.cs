using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace bank.Entities
{

    [Table("Customer")]
    public class Customer
    { 
          [Key]
        public int Accountno { get; set; }
        public int Customerno { get; set; }
        public int BranchId { get; set; }
        public double balance { get; set; }
        public DateTime openingdate { get; set; }

    }
}
