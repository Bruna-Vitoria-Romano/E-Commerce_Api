using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entyties
{
    public class Base
    {
        public Base(long id, string name)
        {
            Id = id;
            Name = name;
        }

        [ForeignKey("Identity")]
        [Key]
        public long Id {  get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Name {  get; set; }
    }
}
