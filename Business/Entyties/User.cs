using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entyties
{
    public class User : Base
    {
        public User(string phone, string email, string password, int id, string name) : base(id, name)
        {
            Phone = phone;
            Email = email;
            Password = password;
        }

        private string Phone {  get; set; }
        private string Email {  get; set; }
        private string Password {  get; set; }
    }
}
