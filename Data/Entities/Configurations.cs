using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Configurations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
