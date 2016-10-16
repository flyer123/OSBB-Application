using OSBB.Windows;
using OSBB.Data;
using System.Windows.Input;
using System.Linq;
using OSBB.DesktopClient.Services;
using OSBB.DesktopClient.Interfaces;

namespace OSBB.DesktopClient.ViewModels
{
    public class SpdtBillViewModel : ViewModel
    {
        private readonly BusinessContext context;
        private ListAppartmentViewModel parentAppartmentViewModel;

        public SpdtBillViewModel(ListAppartmentViewModel apvm)
            : this(new BusinessContext())
        {
            parentAppartmentViewModel = apvm;
        }
        public SpdtBillViewModel(BusinessContext context)
        {
            this.context = context;
        }

        //id of appartment
        public int Id { get; set; }


        //sum of charge
        public decimal MoneyAmmount { get; set; }

        //return the comand
        public ICommand SpdtChargeCommand
        {
            get
            {
                return new ActionCommand(x => SpdtChargeOperation());
            }
        }

        //calculates the spdt bill
        private void SpdtChargeOperation()
        {
            var app = parentAppartmentViewModel.Appartments.FirstOrDefault(x => x.AppartmentId == Id);
            

            //update the given appartment
            context.UpdateAppartment(Id, app.Number, app.Floor, app.LivingArea, app.GeneralArea, app.ElectricityBill, app.ElectricityPayment, app.WaterBill, app.WaterPayment,
            app.GasBill, app.GasPayment, app.SpdtBill + MoneyAmmount, app.SpdtPayment, app.TotalBill + MoneyAmmount, app.TotalPayment, app.ElectricityPrevCounter, app.ElectricityActualCounter, app.WaterPrevCounter,
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
                WaterActualCounter = app.WaterActualCounter,
                GasActualCounter = app.GasActualCounter,
                ElectricityPrevCounter = app.ElectricityPrevCounter,
                WaterPrevCounter = app.WaterPrevCounter,
                GasPrevCounter = app.GasPrevCounter,
                SpdtBill = app.SpdtBill + MoneyAmmount,
                SpdtPayment = app.SpdtPayment,
                ElectricityBill = app.ElectricityBill,
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
