using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModel
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Cannot be null")]
        [MaxLength(255, ErrorMessage ="Maximun length 255")]
        [MinLength(3, ErrorMessage ="Minimun length 3")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cannot be null")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Cannot be null")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Cannot be null")]
        public string Password { get; set; } 
    }
}
