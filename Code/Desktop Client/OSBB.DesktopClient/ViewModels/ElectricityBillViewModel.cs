using OSBB.Windows;
using OSBB.Data;
using System.Windows.Input;
using System.Linq;
using OSBB.DesktopClient.Services;
using OSBB.DesktopClient.Interfaces;

namespace OSBB.DesktopClient.ViewModels
{
    public class ElectricityBillViewModel : ViewModel
    {
        private readonly BusinessContext context;
        private ListAppartmentViewModel parentAppartmentViewModel;

        public ElectricityBillViewModel(ListAppartmentViewModel apvm)
            : this(new BusinessContext())
        {
            parentAppartmentViewModel = apvm;
        }
        public ElectricityBillViewModel(BusinessContext context)
        {
            this.context = context;
        }

        //id of appartment
        public int Id { get; set; }

        //previous counter
        public int PrevCounter { get; set; }

        //actual counter
        public int ActualCounter { get; set; }

        //shows coefficient to calculate charge, depends on difference between the counters
        public decimal Factor { get; set; }

        //sum of charge
        public decimal MoneyAmmount { get; set; }

        //return the comand
        public ICommand ElectricityChargeCommand
        {
            get
            {
                return new ActionCommand(x => ElectricityChargeOperation());
            }
        }

        //calculates the electricity bill
        private void ElectricityChargeOperation()
        {
            var app = parentAppartmentViewModel.Appartments.FirstOrDefault(x => x.AppartmentId == Id);
            
            MoneyAmmount = (ActualCounter - PrevCounter) * Factor;

            //update the given appartment
            context.UpdateAppartment(Id, app.Number, app.Floor, app.LivingArea, app.GeneralArea, app.ElectricityBill + MoneyAmmount, app.ElectricityPayment, app.WaterBill, app.WaterPayment,
            app.GasBill, app.GasPayment, app.SpdtBill, app.SpdtPayment, app.TotalBill + MoneyAmmount, app.TotalPayment, app.ElectricityPrevCounter + PrevCounter, app.ElectricityActualCounter + ActualCounter, app.WaterPrevCounter,
            app.WaterActualCounter, app.GasPrevCounter, app.GasActualCounter);
            int i = parentAppartmentViewModel.Appartments.IndexOf(app);
            parentAppartmentViewModel.Appartments[i] = new Appartment()
            {
                AppartmentId = Id,
                Number = app.Number,
                Floor = app.Floor,
                GeneralArea = app.GeneralArea,
                LivingArea = app.LivingArea,
                ElectricityActualCounter = app.ElectricityActualCounter + ActualCounter,
                WaterActualCounter = app.WaterActualCounter,
                GasActualCounter = app.GasActualCounter,
                ElectricityPrevCounter = app.ElectricityPrevCounter + PrevCounter,
                WaterPrevCounter = app.WaterPrevCounter,
                GasPrevCounter = app.GasPrevCounter,
                SpdtBill = app.SpdtBill,
                SpdtPayment = app.SpdtPayment,
                ElectricityBill = app.ElectricityBill + MoneyAmmount,
                WaterBill = app.WaterBill,
                GasBill = app.GasBill,
                TotalBill = app.TotalBill + MoneyAmmount,
                ElectricityPayment = app.ElectricityPayment,
                WaterPayment = app.WaterPayment,
                GasPayment = app.GasPayment,
                TotalPayment = app.TotalPayment,
            };

        }


    }
}
