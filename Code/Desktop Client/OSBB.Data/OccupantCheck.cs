using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSBB.Data
{
    public static class OccupantCheck
    {
        public static void Require(string value)
        {
            if (value.Trim().Length == 0)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
