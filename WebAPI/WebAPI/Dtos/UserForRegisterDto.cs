using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength =4, ErrorMessage = "You must specify password between 4 and 8 characters!")]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Fullname { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }

    }
}
