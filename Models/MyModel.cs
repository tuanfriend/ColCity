using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ColCitySite.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        // MySQL VARCHAR and TEXT types can be represeted by a string
        [Required]
        [MinLength(2, ErrorMessage = "First name has to be atleast 2 characters!")]
        public string FName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Last name has to be atleast 2 characters!")]
        public string LName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(2, ErrorMessage = "Password has to be atleast 2 characters!")]
        public string Password { get; set; }
        // The MySQL DATETIME type can be represented by a DateTime
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPw { get; set; }
        // public List<UserRoom> ListOfRooms { get; set; }

    }
    public class LoginUser
    {
        // No other fields!
        [Required(ErrorMessage = "Please enter correct Email")]
        public string LoginNickName { get; set; }

        [Required(ErrorMessage = "Please enter your password!")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}