using System;
using System.Collections.Generic;
using System.Linq;
using GenderEnumeration;

namespace OSBB.Data
{
    public sealed class BusinessContext : IDisposable
    {
        private readonly DataContext context;
        private bool disposed;
        public BusinessContext()
        {
            context = new DataContext();
        }
        public DataContext DataContext
        {
            get { return context; }
        }





        //updates selected appartment data
        public void UpdateAppartment(int id, int number, int floor, double living, double general, decimal electricitybill, decimal electricitypayment, decimal waterbill, decimal waterpayment,
            decimal gasbill, decimal gaspayment, decimal spdtbill, decimal spdtpayment, decimal totalbill, decimal totalpayment,
            int electricityprevcounter, int electricityactualcounter, int waterprevcounter, int wateractualcounter, int gasprevcounter, int gasactualcounter)
        {
            Appartment appartment = context.Appartments.Where(x => x.AppartmentId == id).FirstOrDefault<Appartment>();
            appartment.AppartmentId = id;
            appartment.Floor = floor;
            appartment.GeneralArea = general; appartment.LivingArea = living; appartment.Number = number;
            appartment.SpdtBill = spdtbill; appartment.SpdtPayment = spdtpayment; appartment.ElectricityBill = electricitybill;
            appartment.ElectricityPayment = electricitypayment; appartment.WaterBill = waterbill; appartment.WaterPayment = waterpayment;
            appartment.GasBill = gasbill; appartment.GasPayment = gaspayment; appartment.SpdtBill = spdtbill; appartment.SpdtPayment = spdtpayment;
            appartment.TotalBill = appartment.GasBill + appartment.WaterBill + appartment.SpdtBill + appartment.ElectricityBill; 
            appartment.TotalPayment = appartment.GasPayment + appartment.SpdtPayment + appartment.WaterPayment + appartment.ElectricityPayment;
            appartment.ElectricityPrevCounter = electricityprevcounter; appartment.ElectricityActualCounter = electricityactualcounter;
            appartment.WaterPrevCounter = waterprevcounter; appartment.WaterActualCounter = wateractualcounter;
            appartment.GasPrevCounter = gasprevcounter; appartment.GasActualCounter = gasactualcounter;
            AppartmentCheck.Require(appartment.LivingArea);
            AppartmentCheck.Require(appartment.GeneralArea);
            AppartmentCheck.Require(appartment.Number);
            AppartmentCheck.Require(appartment.Floor);
            AppartmentCheck.CheckArea(appartment.LivingArea, appartment.GeneralArea);
            context.Entry(appartment).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }



        //add newly created appartment to repository
        public int AddNewAppartment(int number, int floor, double living, double general, decimal electricitybill, decimal electricitypayment, decimal waterbill, decimal waterpayment,
            decimal gasbill, decimal gaspayment, decimal spdtbill, decimal spdtpayment, decimal totalbill, decimal totalpayment,
            int electricityprevcounter, int electricityactualcounter, int waterprevcounter, int wateractualcounter, int gasprevcounter, int gasactualcounter)
        {
            Appartment appartment = new Appartment();
            appartment.Floor = floor;
            appartment.GeneralArea = general; appartment.LivingArea = living; appartment.Number = number;
            appartment.SpdtBill = spdtbill; appartment.SpdtPayment = spdtpayment; appartment.ElectricityBill = electricitybill;
            appartment.ElectricityPayment = electricitypayment; appartment.WaterBill = waterbill; appartment.WaterPayment = waterpayment;
            appartment.GasBill = gasbill; appartment.GasPayment = gaspayment; appartment.SpdtBill = spdtbill; appartment.SpdtPayment = spdtpayment;
            appartment.TotalBill = totalbill; appartment.TotalPayment = totalpayment;
            appartment.ElectricityPrevCounter = electricityprevcounter; appartment.ElectricityActualCounter = electricityactualcounter;
            appartment.WaterPrevCounter = waterprevcounter; appartment.WaterActualCounter = wateractualcounter;
            appartment.GasPrevCounter = gasprevcounter; appartment.GasActualCounter = gasactualcounter;
            AppartmentCheck.Require(appartment.LivingArea);
            AppartmentCheck.Require(appartment.GeneralArea);
            AppartmentCheck.Require(appartment.Number);
            AppartmentCheck.Require(appartment.Floor);
            AppartmentCheck.CheckArea(appartment.LivingArea, appartment.GeneralArea);
            context.Appartments.Add(appartment);
            context.SaveChanges();
            return appartment.AppartmentId;
        }


        //delete selected appartment
        public void DeleteAppartment(int id)
        {
            var app = context.Appartments.Where(s => s.AppartmentId == id).FirstOrDefault();
            context.Appartments.Remove(app);
            context.SaveChanges();
        }


        //gets list of appartments
        //in order to display it in main window
        public ICollection<Appartment> GetAppartmentList()
        {
            return context.Appartments.OrderBy(x => x.AppartmentId).ToArray();
        }


        //Filters appartments by min and max
        //values of total charge, and sorting them
        public List<Appartment> FilterAppartment(decimal min, decimal max, string criterion, bool isascending)
        {

            switch (criterion)
            {
                case "gasCharge":
                    {
                        if (isascending)
                        {
                            return context.Appartments.Where(x => x.GasBill >= min && x.GasBill <= max).ToList();
                        }
                        else
                        {
                            return context.Appartments.Where(x => x.GasBill >= min && x.GasBill <= max).OrderByDescending(s => s.GasBill).ToList();
                        }
                    }
                case "waterCharge":
                    {
                        if (isascending)
                        {
                            return context.Appartments.Where(x => x.WaterBill >= min && x.WaterBill <= max).ToList();
                        }
                        else
                        {
                            return context.Appartments.Where(x => x.WaterBill >= min && x.WaterBill <= max).OrderByDescending(s => s.GasBill).ToList();
                        }
                    }
                case "spdtCharge":
                    {
                        if (isascending)
                        {
                            return context.Appartments.Where(x => x.SpdtBill >= min && x.SpdtBill <= max).ToList();
                        }
                        else
                        {
                            return context.Appartments.Where(x => x.SpdtBill >= min && x.SpdtBill <= max).OrderByDescending(s => s.GasBill).ToList();
                        }
                    }
                case "electricityCharge":
                    {
                        if (isascending)
                        {
                            return context.Appartments.Where(x => x.ElectricityBill >= min && x.ElectricityBill <= max).ToList();
                        }
                        else
                        {
                            return context.Appartments.Where(x => x.ElectricityBill >= min && x.ElectricityBill <= max).OrderByDescending(s => s.GasBill).ToList();
                        }
                    }
                case "gasPayment":
                    {
                        if (isascending)
                        {
                            return context.Appartments.Where(x => x.GasPayment >= min && x.GasPayment <= max).ToList();
                        }
                        else
                        {
                            return context.Appartments.Where(x => x.GasPayment >= min && x.GasPayment <= max).OrderByDescending(s => s.GasBill).ToList();
                        }
                    }
                case "waterPayment":
                    {
                        if (isascending)
                        {
                            return context.Appartments.Where(x => x.WaterPayment >= min && x.WaterPayment <= max).ToList();
                        }
                        else
                        {
                            return context.Appartments.Where(x => x.WaterPayment >= min && x.WaterPayment <= max).OrderByDescending(s => s.GasBill).ToList();
                        }
                    }
                case "spdtPayment":
                    {
                        if (isascending)
                        {
                            return context.Appartments.Where(x => x.SpdtPayment >= min && x.SpdtPayment <= max).ToList();
                        }
                        else
                        {
                            return context.Appartments.Where(x => x.SpdtPayment >= min && x.SpdtPayment <= max).OrderByDescending(s => s.GasBill).ToList();
                        }
                    }
                case "electricityPayment":
                    {
                        if (isascending)
                        {
                            return context.Appartments.Where(x => x.ElectricityPayment >= min && x.ElectricityPayment <= max).ToList();
                        }
                        else
                        {
                            return context.Appartments.Where(x => x.ElectricityPayment >= min && x.ElectricityPayment <= max).OrderByDescending(s => s.GasBill).ToList();
                        }
                    }
                case "totalCharge":
                    {
                        if (isascending)
                        {
                            return context.Appartments.Where(x => x.TotalBill >= min && x.TotalBill <= max).ToList();
                        }
                        else
                        {
                            return context.Appartments.Where(x => x.TotalBill >= min && x.TotalBill <= max).OrderByDescending(s => s.GasBill).ToList();
                        }

                    }
                case "totalPayment":
                    {
                        if (isascending)
                        {
                            return context.Appartments.Where(x => x.TotalPayment >= min && x.TotalPayment <= max).ToList();
                        }
                        else
                        {
                            return context.Appartments.Where(x => x.TotalPayment >= min && x.TotalPayment <= max).OrderByDescending(s => s.GasBill).ToList();
                        }

                    }
            }
            return null;
        }




        //updates data of selected person
        public void UpdateOccupant(int id, int appartmentId, string first, string last, string middle, Gender gender, DateTime birthDate, bool owner)
        {
             Occupant  occupant = context.Occupants.Where(x => x.OccupantId == id).FirstOrDefault<Occupant>();
             occupant.FirstName = first; occupant.LastName = last; occupant.MiddleName = middle;
             occupant.Gender = gender; occupant.BirthDate = birthDate; occupant.Owner = owner;
             OccupantCheck.Require(occupant.FirstName);
             OccupantCheck.Require(occupant.LastName);
             context.Entry(occupant).State = System.Data.Entity.EntityState.Modified;
             context.SaveChanges();
        }




        //adds newly created person to selected appartment
        //and to repository
        public int AddNewOccupant(int appartmentId, string first, string last, string middle, Gender gender, DateTime birthDate, bool owner)
        {
            Occupant occupant = new Occupant();
            occupant.AppartmentId = appartmentId;
            occupant.FirstName = first; occupant.LastName = last; occupant.MiddleName = middle;
            occupant.Gender = gender; occupant.BirthDate = birthDate; occupant.Owner = owner;
            OccupantCheck.Require(occupant.FirstName);
            OccupantCheck.Require(occupant.LastName);
            context.Occupants.Add(occupant);
            context.SaveChanges();
            return occupant.OccupantId;
        }

        //deletes selected person
        public bool DeleteOccupant(int id)
        {
            var ocp = context.Occupants.Where(s => s.OccupantId == id).FirstOrDefault();
            context.Occupants.Remove(ocp);
            context.SaveChanges();
            ocp = context.Occupants.Where(s => s.OccupantId == id).FirstOrDefault();
            if (ocp == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //returns persons list for selected appartment
        public ICollection<Occupant> GetOccupantList(int id)
        {
            return context.Occupants.Where(x => x.AppartmentId == id).OrderBy(x => x.OccupantId).ToArray();
        }


        #region DisposeRegionMembers
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected void Dispose(bool disposing)
        {
            if (disposed || !disposing)
                return;
            if (context != null)
                context.Dispose();
            disposed = true;
        }
        #endregion




        //remove this

        #region obsolete
        //charges selected appartment with selected sum of money
        //public void ChargeSelectedAppartment(int id, decimal charge)
        //{
        //    Appartment appartment = context.Appartments.Where(x => x.AppartmentId == id).FirstOrDefault<Appartment>();
        //    context.Entry(appartment).State = System.Data.Entity.EntityState.Modified;
        //    appartment.TotalBill = appartment.TotalBill + charge;
        //    context.SaveChanges();
        //}

        ////creates pyment for selected appartment
        //public void PaySelectedAppartment(int id, decimal payment)
        //{
        //    Appartment appartment = context.Appartments.Where(x => x.AppartmentId == id).FirstOrDefault<Appartment>();
        //    context.Entry(appartment).State = System.Data.Entity.EntityState.Modified;
        //    appartment.TotalPayment = appartment.TotalPayment + payment;
        //    context.SaveChanges();
        //}

        #endregion
    }
}
