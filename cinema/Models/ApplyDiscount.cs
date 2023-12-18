using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cinema.Models
{
    [PrimaryKey(nameof(dis_id), nameof(bi_id))]
    public class ApplyDiscount
    {
        [Required]
        [StringLength(10)]
        public string dis_id { get; set; }
        [ForeignKey(nameof(dis_id))]
        public virtual Discount discount { get; set; }

        [Required]
        [StringLength(10)]
        public string bi_id { get; set; }
        [ForeignKey(nameof(bi_id))]
        public virtual Bill bill { get; set; }
    }
}
