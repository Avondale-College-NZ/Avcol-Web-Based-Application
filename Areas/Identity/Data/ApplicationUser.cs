using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Avondale_College.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
       public string FullName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string TeacherOrStudent { get; set; }
    }
}
