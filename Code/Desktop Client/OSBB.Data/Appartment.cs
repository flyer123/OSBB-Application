using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace OSBB.Data
{
    /// <summary>
    /// Describes characteristics pf appaprtment
    /// </summary>
    public class Appartment
    {
        public Appartment()
        {

        }


        public int AppartmentId { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public double LivingArea { get; set; }
        public double GeneralArea { get; set; }
        public decimal ElectricityBill { get; set; }
        public decimal WaterBill { get; set; }
        public decimal GasBill { get; set; }
        public decimal SpdtBill { get; set; }
        public decimal TotalBill { get; set; }
        public decimal ElectricityPayment { get; set; }
        public decimal WaterPayment { get; set; }
        public decimal GasPayment { get; set; }
        public decimal SpdtPayment { get; set; }
        public decimal TotalPayment { get; set; }
        public int ElectricityPrevCounter { get; set; }
        public int ElectricityActualCounter { get; set; }
        public int WaterPrevCounter { get; set; }
        public int WaterActualCounter { get; set; }
        public int GasPrevCounter { get; set; }
        public int GasActualCounter { get; set; }

        public virtual ObservableCollection<Occupant> Occupants { get; set; }
    }
}
