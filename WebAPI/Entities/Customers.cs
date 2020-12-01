using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Entities
{
    [Table("Customers")]
    public class Customers
    {
        [Column("CustomerID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int CustomerID { get; set; }

        [Column("CompanyName")]
        [Required]
        [StringLength(100)]
        public String CompanyName { get; set; }
    }
}
