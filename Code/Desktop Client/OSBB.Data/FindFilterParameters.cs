using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSBB.Data
{
    public class FindFilterParameters
    {
        public string Criterion { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public bool IsAscending { get; set; }
    }
}
