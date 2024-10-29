using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entyties
{
    public class User : Base
    {
        public User(string phone, string email, string password, long id, string name) : base(id, name)
        {
            Phone = phone;
            Email = email;
            Password = password;
        }

        [Required]
        [DataType(DataType.PhoneNumber)]
        private string Phone {  get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        private string Email {  get; set; }

        [Required]
        [DataType (DataType.Password)]
        private string Password {  get; set; }
    }
}
