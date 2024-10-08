using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Core.DTO
{
    public class ProductDTO : BaseDTO
    {
        public string Description { get; set; } = string.Empty;
        public Enum Status { get; set; }
    }
}
