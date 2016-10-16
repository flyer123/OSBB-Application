using OSBB.Windows;
using OSBB.Data;
using System.Windows.Input;
using System.Linq;
using OSBB.DesktopClient.Services;
using OSBB.DesktopClient.Interfaces;

namespace OSBB.DesktopClient.ViewModels
{
    public class WaterBillViewModel : ViewModel
    {
        private readonly BusinessContext context;
        private ListAppartmentViewModel parentAppartmentViewModel;

        public WaterBillViewModel(ListAppartmentViewModel apvm)
            : this(new BusinessContext())
        {
            parentAppartmentViewModel = apvm;
        }
        public WaterBillViewModel(BusinessContext context)
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
        public ICommand WaterChargeCommand
        {
            get
            {
                return new ActionCommand(x => WaterChargeOperation());
            }
        }

        //calculates spdt bill
        private void WaterChargeOperation()
        {
            var app = parentAppartmentViewModel.Appartments.FirstOrDefault(x => x.AppartmentId == Id);
            
            MoneyAmmount = (ActualCounter - PrevCounter) * Factor;

            //update given appartment
            context.UpdateAppartment(Id, app.Number, app.Floor, app.LivingArea, app.GeneralArea, app.ElectricityBill, app.ElectricityPayment, app.WaterBill + MoneyAmmount, app.WaterPayment,
            app.GasBill, app.GasPayment, app.SpdtBill, app.SpdtPayment, app.TotalBill + MoneyAmmount, app.TotalPayment, app.ElectricityPrevCounter, app.ElectricityActualCounter, app.WaterPrevCounter,
            app.WaterActualCounter, app.GasPrevCounter, app.GasActualCounter);
            int i = parentAppartmentViewModel.Appartments.IndexOf(app);
            parentAppartmentViewModel.Appartments[i] = new Appartment()
            {
                AppartmentId = Id,
                Number = app.Number,
                Floor = app.Floor,
                GeneralArea = app.GeneralArea,
                LivingArea = app.LivingArea,
                ElectricityActualCounter = app.ElectricityActualCounter,
                WaterActualCounter = app.WaterActualCounter + ActualCounter,
                GasActualCounter = app.GasActualCounter,
                ElectricityPrevCounter = app.ElectricityPrevCounter,
                WaterPrevCounter = app.WaterPrevCounter + PrevCounter,
                GasPrevCounter = app.GasPrevCounter,
                SpdtBill = app.SpdtBill,
                SpdtPayment = app.SpdtPayment,
                ElectricityBill = app.ElectricityBill,
                WaterBill = app.WaterBill + MoneyAmmount,
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
