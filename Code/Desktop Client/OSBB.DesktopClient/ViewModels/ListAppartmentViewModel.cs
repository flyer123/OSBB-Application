using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;
using OSBB.Windows;
using OSBB.Data;
using OSBB.DesktopClient.Services;
using OSBB.DesktopClient.Interfaces;
using ModeEnumeration;

namespace OSBB.DesktopClient.ViewModels
{
    /// <summary>
    /// viewmodel for main window
    /// to display list of appartments
    /// </summary>
    public class ListAppartmentViewModel : ViewModel
    {
        //to differentiate between payment and charge
        public ModeEnumeration.Mode mode { get; private set; }

        private readonly BusinessContext context;
        private Appartment selectedAppartment;
        private Occupant selectedOccupant;
        private SelectedAppartmentViewModel openAppartmentViewModel;
        private SelectedOccupantViewModel openOccupantViewModel;
        //private PaymentModeEnum paymentMode;


        /// <summary>
        /// Initializis of new instance of AppartmentViewModel class
        /// </summary>
        public ListAppartmentViewModel() : this (new BusinessContext())
        {
        }

        public ListAppartmentViewModel(BusinessContext context)
        {
            Appartments = new ObservableCollection<Appartment>();
            openAppartmentViewModel = new SelectedAppartmentViewModel(this, this.context);
            openOccupantViewModel = new SelectedOccupantViewModel(this);
            this.context = context;
        }



        //returns viewmodel to edit or create new appartment
        public SelectedAppartmentViewModel OpenAppartmentViewModel
        {
            get
            {
                return openAppartmentViewModel;
            }
            private set
            {
                openAppartmentViewModel = value;
            }
        }

        //returns viewmodel to edit or create person
        public SelectedOccupantViewModel OpenOccupantViewModel
        {
            get
            {
                return openOccupantViewModel;
            }
            private set
            {
                openOccupantViewModel = value;
            }
        }

        //apaprtments to display
        public ObservableCollection<Appartment> Appartments
        { 
            get; 
            private set;
        }

        //returns selected appartment
        public Appartment SelectedAppartment
        {
            get
            {
                return selectedAppartment;
            }
            set
            {
                selectedAppartment = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("AppartmentIsSelected");
            }
        }

        //returns selected person
        public Occupant SelectedOccupant
        {
            get 
            { 
                return selectedOccupant;
            }
            set
            {
                selectedOccupant = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("OccupantIsSelected");
            }
        }

        //to check if selected appartment != null
        public bool AppartmentIsSelected
        {
            get
            {
                return selectedAppartment != null;
            }
        }


        #region public commands region

        public ICommand GetAppartmentsCommand
        {
            get
            {
                return new ActionCommand(x => GetAppartmentList());
            }
        }

        public ICommand DeleteAppartmentCommand
        {
            get
            {
                return new ActionCommand(x => DeleteAppartment());
            }
        }

        public ICommand OpenAppartmentCommand
        {
            get
            {
                
                return new ActionCommand(x => OpenAppartmentForEdit());
            }
        }

        public ICommand OpenNewAppartmentCommand
        {
            get
            {
                return new ActionCommand(x => OpenNewAppartment());
            }
        }

        public ICommand OpenOccupantForEditCommand
        {
            get
            {
                return new ActionCommand(x => OpenOccupantForEdit());
            }
        }


        public ICommand OpenNewOccupantCommand
        {
            get
            {
                return new ActionCommand(x => OpenNewOccupant());
            }
        }

        public ICommand OpenElectricityBillDialogCommand
        {
            get
            {
                return new ActionCommand(x => OpenElectricityBillDialog());
            }
        }
        public ICommand OpenWaterBillDialogCommand
        {
            get
            {
                return new ActionCommand(x => OpenWaterBillDialog());
            }
        }
        public ICommand OpenGasBillDialogCommand
        {
            get
            {
                return new ActionCommand(x => OpenGasBillDialog());
            }
        }
        public ICommand OpenSpdtBillDialogCommand
        {
            get
            {
                return new ActionCommand(x => OpenSpdtBillDialog());
            }
        }

        public ICommand DeleteOccupantCommand
        {
            get
            {
                return new ActionCommand(x => DeleteOccupant());
            }
        }

        public ICommand OpenElectricityPaymentDialogCommand
        {
            get
            {
                return new ActionCommand(x => OpenElectricityPaymentDialog());
            }
        }

        public ICommand GasPaymentDialogCommand
        {
            get
            {
                return new ActionCommand(x => OpenGasPaymentDialog());
            }
        }

        public ICommand OpenWaterPaymentDialogCommand
        {
            get
            {
                return new ActionCommand(x => OpenWaterPaymentDialog());
            }
        }

        public ICommand OpenSpdtPaymentDialogCommand
        {
            get
            {
                return new ActionCommand(x => OpenSpdtPaymentDialog());
            }
        }

        public ICommand FilterCommand
        {
            get
            {

                return new ActionCommand(x => FilterResults(x));
            }
        }
        #endregion


        #region private helpers region
        private void GetAppartmentList()
        {
            using (var api = new BusinessContext())
            {
                Appartments.Clear();
                context.GetAppartmentList();
                selectedAppartment = null;
                foreach (var appartment in context.GetAppartmentList())
                    Appartments.Add(appartment);
            }
        }

        private void DeleteAppartment()
        {
            if (this.selectedAppartment != null)
            {
                context.DeleteAppartment(selectedAppartment.AppartmentId);
                context.DataContext.SaveChanges();
                Appartments.Remove(selectedAppartment);
                selectedAppartment = null;
            }
        }




        //Open selected appartment
        private void OpenAppartmentForEdit()
        {
            mode = Mode.Edit;
            SelectedAppartmentViewModel selectedAppartmentViewModel = new SelectedAppartmentViewModel(this, this.context) {
             ElectricityBill = selectedAppartment.ElectricityBill, SpdtBill = selectedAppartment.SpdtBill, WaterBill = selectedAppartment.WaterBill,
             GasBill = selectedAppartment.GasBill, ElectricityPayment = selectedAppartment.ElectricityPayment, SpdtPayment = selectedAppartment.SpdtPayment,
             WaterPayment = selectedAppartment.WaterPayment, GasPayment = selectedAppartment.GasPayment,
             ElectricityPrevCounter = selectedAppartment.ElectricityPrevCounter, ElectricityActualCounter = selectedAppartment.ElectricityActualCounter,
             WaterPrevCounter = selectedAppartment.WaterPrevCounter,
             WaterActualCounter = selectedAppartment.WaterActualCounter,
             GasPrevCounter = selectedAppartment.GasPrevCounter,
             GasActualCounter = selectedAppartment.GasActualCounter,
                TotalBill = selectedAppartment.TotalBill, Floor = selectedAppartment.Floor, Id = selectedAppartment.AppartmentId, GeneralArea = selectedAppartment.GeneralArea, LivingArea = selectedAppartment.LivingArea,
             Number = selectedAppartment.Number, TotalPayment = selectedAppartment.TotalPayment};
            IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("appartmentImplementation");
            dialog.BindViewModel(selectedAppartmentViewModel);
            dialog.ShowDialog();
        }

        //open dialog window for new appartment
        private void OpenNewAppartment()
        {
            mode = Mode.Create;
            SelectedAppartmentViewModel selectedAppartmentViewModel = new SelectedAppartmentViewModel(this, this.context);
            IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("appartmentImplementation");
            dialog.BindViewModel(selectedAppartmentViewModel);
            dialog.ShowDialog();

        }

        //opens dialog to edit selected occupant
        private void OpenOccupantForEdit()
        {
            mode = Mode.Edit;
            SelectedOccupantViewModel ocvm = new SelectedOccupantViewModel(this) {AppartmentId = SelectedOccupant.AppartmentId, SelectedGender = SelectedOccupant.Gender,
             BirthDate = SelectedOccupant.BirthDate, FirstName = SelectedOccupant.FirstName, LastName = SelectedOccupant.LastName,
             MiddleName = SelectedOccupant.MiddleName, Owner = SelectedOccupant.Owner, Id = SelectedOccupant.OccupantId};
            IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("occupantImplementation");
            dialog.BindViewModel(ocvm);
            dialog.ShowDialog();
        }

        //open dialog to create new occupant for given appartment
        private void OpenNewOccupant()
        {
            mode = Mode.Create;
            SelectedOccupantViewModel ocvm = new SelectedOccupantViewModel(this);
            ocvm.AppartmentId = selectedAppartment.AppartmentId;
            IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("occupantImplementation");
            dialog.BindViewModel(ocvm);
            dialog.ShowDialog();
        }

        private void DeleteOccupant()
        {
            if (this.selectedOccupant != null)
            {
                context.DataContext.Occupants.Remove(selectedOccupant);
                context.DataContext.SaveChanges();
                selectedOccupant = null;
            }
        }

        public bool OccupantIsSelected
        {
            get
            {
                return selectedOccupant != null;
            }
        }

        //open dialog for electricity bill
        private void OpenElectricityBillDialog()
        {
            if (this.selectedAppartment != null)
            {
                ElectricityBillViewModel electricityBillViewModel = new ElectricityBillViewModel(this)
                {
                    Id = selectedAppartment.AppartmentId,
                };
                IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("electricityBillDialogImplementation");
                dialog.BindViewModel(electricityBillViewModel);
                dialog.ShowDialog();
            }
        }

        //open dialog for water bill
        private void OpenWaterBillDialog()
        {
            if (this.selectedAppartment != null)
            {
                WaterBillViewModel waterBillViewModel = new WaterBillViewModel(this)
                {
                    Id = selectedAppartment.AppartmentId,
                };
                IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("waterBillDialogImplementation");
                dialog.BindViewModel(waterBillViewModel);
                dialog.ShowDialog();
            }
        }

        //open dialog for gas bill
        private void OpenGasBillDialog()
        {
            if (this.selectedAppartment != null)
            {
                GasBillViewModel gasBillViewModel = new GasBillViewModel(this)
                {
                    Id = selectedAppartment.AppartmentId,
                };
                IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("gasBillDialogImplementation");
                dialog.BindViewModel(gasBillViewModel);
                dialog.ShowDialog();
            }
        }

        //open dialog for spdt bill
        private void OpenSpdtBillDialog()
        {
            if (this.selectedAppartment != null)
            {
                SpdtBillViewModel spdtBillViewModel = new SpdtBillViewModel(this)
                {
                    Id = selectedAppartment.AppartmentId,
                };
                IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("spdtBillDialogImplementation");
                dialog.BindViewModel(spdtBillViewModel);
                dialog.ShowDialog();
            }
        }

        //open dialog for payment for electricity
        private void OpenElectricityPaymentDialog()
        {
            if (this.selectedAppartment != null)
            {
                MoneyOperationViewModel paymentViewModel = new MoneyOperationViewModel(this, PaymentModeEnum.Electricity)
                {
                    Id = selectedAppartment.AppartmentId,
                   MoneyAmmount = 0.0m
                };
                IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("paymentOperationDialogImplementation");
                dialog.BindViewModel(paymentViewModel);
                dialog.ShowDialog();
            }
        }

        //open dialog for payment for water
        private void OpenWaterPaymentDialog()
        {
            if (this.selectedAppartment != null)
            {
                MoneyOperationViewModel paymentViewModel = new MoneyOperationViewModel(this, PaymentModeEnum.Water)
                {
                    Id = selectedAppartment.AppartmentId,
                    MoneyAmmount = 0.0m
                };
                IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("paymentOperationDialogImplementation");
                dialog.BindViewModel(paymentViewModel);
                dialog.ShowDialog();
            }
        }


        //open dialog for payment for gas
        private void OpenGasPaymentDialog()
        {
            if (this.selectedAppartment != null)
            {
                MoneyOperationViewModel paymentViewModel = new MoneyOperationViewModel(this, PaymentModeEnum.Gas)
                {
                    Id = selectedAppartment.AppartmentId,
                    MoneyAmmount = 0.0m
                };
                IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("paymentOperationDialogImplementation");
                dialog.BindViewModel(paymentViewModel);
                dialog.ShowDialog();
            }
        }

        //open dialog for payment fo spdt
        private void OpenSpdtPaymentDialog()
        {
            if (this.selectedAppartment != null)
            {
                MoneyOperationViewModel paymentViewModel = new MoneyOperationViewModel(this, PaymentModeEnum.Spdt)
                {
                    Id = selectedAppartment.AppartmentId,
                    MoneyAmmount = 0.0m
                };
                IModalDialog dialog = ServiceProvider.Instance.Get<IModalDialog>("paymentOperationDialogImplementation");
                dialog.BindViewModel(paymentViewModel);
                dialog.ShowDialog();
            }
        }

        private void FilterResults(object ob)
        {
        }
        #endregion
    }
}
