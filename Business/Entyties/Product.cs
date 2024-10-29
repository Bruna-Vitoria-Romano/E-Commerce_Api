using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entyties
{
    [Table("Product")]
    public class Product : Base
    {
        public Product(string description, Enum status, long id, string name) : base(id, name)
        {
            Description = description;
            Status = status;
        }

        [Required]
        [StringLength(255), MinLength(3)]
        private string Description {  get; set; }

        [Required]
        private Enum Status {  get; set; }
    }
}
