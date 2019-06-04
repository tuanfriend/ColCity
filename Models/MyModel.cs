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

        public string Picture { get; set; }

        public int TypeUser { get; set; } = 0;

        [Required]
        [MinLength(2, ErrorMessage = "Email has to be atleast 2 characters!")]
        public string Email { get; set; }

        public string Phone {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(2, ErrorMessage = "Password has to be atleast 2 characters!")]
        public string Password { get; set; }

        public string City {get; set;}

        public string State {get; set;}
        public int Zipcode {get; set;}
        public int NumVote {get; set;}
        // The MySQL DATETIME type can be represented by a DateTime
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPw { get; set; }
        // public List<UserRoom> ListOfRooms { get; set; }

        public List<Business> ListOfBusiness {get; set;}

    }
    public class LoginUser
    {
        // No other fields!
        [Required(ErrorMessage = "Please enter correct Email")]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "Please enter your password!")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }

    public class Business 
    {
        [Key]
        public int BusID {get; set;}
        public int UserID {get; set;}

        [Required(ErrorMessage = "Please enter business name!")]
        public string BusName {get; set;}
        [Required(ErrorMessage = "Please enter address!")]
        public string BusAddress {get; set;}
        [Required(ErrorMessage = "Please enter city!")]
        public string BusCity {get; set;}
        [Required(ErrorMessage = "Please enter zip code!")]
        public int BusZip {get; set;}
        



    }

    // public class UserBusiness
    // {
    //     [Key]
    //     public int UserBusinessID {get; set;}
    //     public int UserID { get; set;}
    //     public int BusID {get; set;}

    // }
}