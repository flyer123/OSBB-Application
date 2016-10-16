using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSBB.Data
{

    /// <summary>
    /// this auxiliary class used to check
    /// appartment's data for consistency
    /// </summary>
    public static class AppartmentCheck
    {
        public static void Require(double val)
        {
            if (val < 0)
                throw new ArgumentOutOfRangeException();
        }
        public static void Require(int val)
        {
            if (val < 0)
                throw new ArgumentOutOfRangeException();
        }
        
        public static void CheckArea(double area1, double area2)
        {
            if(area2 < area1)
                throw new ArgumentException();
        }
    }
}
