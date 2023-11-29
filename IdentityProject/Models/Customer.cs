using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IdentityProject.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int c_id { get; set; }


        [DataType(DataType.Text)]
        public string cus_name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string cus_phone { get; set; }

        
        [DataType(DataType.EmailAddress)]
        [EmailAddress]

        public string cus_email { get; set; }

        [DataType(DataType.Text)]


        
        public string cus_gender { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
 
        public DateTime cus_dob { get; set; }
        public string cus_type { get; set; }
        public int cus_point { get; set; }
    }
}
