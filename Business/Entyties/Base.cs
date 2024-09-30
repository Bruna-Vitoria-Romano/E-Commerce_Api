using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entyties
{
    public class Base
    {
        public Base(int id, string name)
        {
            Id = id;
            Name = name;
        }

        private int Id {  get; set; }
        private string Name {  get; set; }
    }
}
