using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entyties
{
    public class Product : Base
    {
        public Product(string description, Enum status, int id, string name) : base(id, name)
        {
            Description = description;
            Status = status;
        }

        private string Description {  get; set; }
        private Enum Status {  get; set; }
    }
}
