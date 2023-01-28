//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobPortal2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int UserId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name field is empty!"), MaxLength(25)]
        public string UserName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email field is empty!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }


        [Required(ErrorMessage = "Contact field is empty!")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "Country field is empty!")]
        public string Country { get; set; }

        public Nullable<int> RoleId { get; set; }
        
        public virtual Role Role { get; set; }
    }
}
