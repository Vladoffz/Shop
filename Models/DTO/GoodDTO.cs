using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class GoodDTO
    {
        public int id { get; set; }
        public string Name { get;  set; }
        public int Weight { get;  set; }
        public int Height { get; set; }
        public int Width { get;  set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
