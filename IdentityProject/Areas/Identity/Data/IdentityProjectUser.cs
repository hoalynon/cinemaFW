using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Areas.Identity.Data;

// Add profile data for application users by adding properties to the IdentityProjectUser class
public class IdentityProjectUser : IdentityUser
{


    [Required]
    
    [StringLength(100, MinimumLength = 5)]
    public string? cus_name { get; set; }

    [Required]

    public string? cus_phone { get; set; }

    [Required]
    public string? cus_gender { get; set; }

    [Required]
    public DateTime? cus_dob { get; set; } 

    public string? cus_type { get; set; }
    public int? cus_point { get; set; }
}

