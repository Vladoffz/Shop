using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{ 
    public class DestinationDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Distance { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
