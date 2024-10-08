using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Core.DTO
{
    public class BaseDTO
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
