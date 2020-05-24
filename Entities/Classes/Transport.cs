using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{ 
    public class Transport
    {
        public int id { get; set; }
        public string Name  {  get;  set;  }
        public int MaxWeight { get;  set; }
        public int MaxHeight { get;  set; }
        public int MaxWidth { get;  set; }
        public int Speed { get;  set; }
    }
}
