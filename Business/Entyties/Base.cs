using System;
using System.Collections.Generic;
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

        public long Id {  get; set; }
        public string Name {  get; set; }
    }
}
