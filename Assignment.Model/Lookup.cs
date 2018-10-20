using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
   public class Lookup
    {
        public Lookup()
        {

        }
        public Lookup(int code, string description)
        {
            Code = code;
            Description = description;

        }
        public int Code { get; set; }
        public string Description { get; set; }
    }
}
