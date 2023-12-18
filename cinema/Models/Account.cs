using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cinema.Models
{

        public class Account
        {
            [Key]
            [Required]
            [StringLength(50)]
            public string cus_email { get; set; }
            [ForeignKey(nameof(cus_email))]
            public virtual Customer Customer { get; set; }

            [Required]
            [StringLength(100)]
            public string c_pass { get; set; }

            [Required]
            [StringLength(20)]
            public string c_role { get; set; }
        }
}
