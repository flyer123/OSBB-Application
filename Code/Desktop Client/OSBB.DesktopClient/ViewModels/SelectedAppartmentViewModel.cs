using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Input;
using System.Windows;
using OSBB.Windows;
using OSBB.Data;
using ModeEnumeration;

namespace OSBB.DesktopClient.ViewModels
{
    public class SelectedAppartmentViewModel : ViewModel
    {
        private readonly BusinessContext context;
        private ListAppartmentViewModel parentAppartmentViewModel;
        private Mode mode;
        public SelectedAppartmentViewModel(ListAppartmentViewModel apvm, BusinessContext context)
        {
            parentAppartmentViewModel = apvm;
            mode = apvm.mode;
            this.context = context;
        }

        private int id; private int number; private int floor; private double livingArea; private double generalArea;
        private decimal spdtBill; private decimal spdtPayment;
        private decimal electricityBill; private decimal electricityPayment;
        private decimal waterBill; private decimal waterPayment;
        private decimal gasBill; private decimal gasPayment;
        private decimal totalBill; private decimal totalPayment;
        private int electricityPrevCounter, electricityActualCounter;
        private int waterPrevCounter, waterActualCounter;
        private int gasPrevCounter, gasActualCounter;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public bool CanModify
        {
            get
            {
                return !(Number < 0) && !(Floor < 0) && !(GeneralArea < LivingArea);

            }
        }


        #region characteristics
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                floor = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        public double GeneralArea
        {
            get
            {
                return generalArea;
            }
            set
            {
                generalArea = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        public double LivingArea
        {
            get
            {
                return livingArea;
            }
            set
            {
                livingArea = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        #endregion

        #region bills and payment region members
        public decimal ElectricityBill
        {
            get
            {
                return electricityBill;
            }
            set
            {
                electricityBill = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        public decimal ElectricityPayment
        {
            get
            {
                return electricityPayment;
            }
            set
            {
                electricityPayment = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }
        public decimal WaterBill
        {
            get
            {
                return waterBill;
            }
            set
            {
                waterBill = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        public decimal WaterPayment
        {
            get
            {
                return waterPayment;
            }
            set
            {
                waterPayment = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }
        public decimal GasBill
        {
            get
            {
                return gasBill;
            }
            set
            {
                gasBill = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        public decimal GasPayment
        {
            get
            {
                return gasPayment;
            }
            set
            {
                gasPayment = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }
        public decimal SpdtBill
        {
            get
            {
                return spdtBill;
            }
            set
            {
                spdtBill = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        public decimal SpdtPayment
        {
            get
            {
                return spdtPayment;
            }
            set
            {
                spdtPayment = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        public decimal TotalBill
        {
            get
            {
                return totalBill;
            }
            set
            {
                totalBill = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        public decimal TotalPayment
        {
            get
            {
                return totalPayment;
            }
            set
            {
                totalPayment = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        #endregion


        #region counters

        public int ElectricityPrevCounter
        {
            get
            {
                return electricityPrevCounter;
            }
            set
            {
                electricityPrevCounter = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        public int ElectricityActualCounter
        {
            get
            {
                return electricityActualCounter;
            }
            set
            {
                electricityActualCounter = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }
        public int WaterPrevCounter
        {
            get
            {
                return waterPrevCounter;
            }
            set
            {
                waterPrevCounter = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        public int WaterActualCounter
        {
            get
            {
                return waterActualCounter;
            }
            set
            {
                waterActualCounter = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }
        public int GasPrevCounter
        {
            get
            {
                return gasPrevCounter;
            }
            set
            {
                gasPrevCounter = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        public int GasActualCounter
        {
            get
            {
                return gasActualCounter;
            }
            set
            {
                gasActualCounter = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }

        }

        #endregion

       

        public ICommand UpdateAppartmentCommand
        {
            get
            {
                return new ActionCommand(x => UpdateAppartment(), x => CanModify);
            }
        }

        private void UpdateAppartment()
        {
            if (mode == Mode.Create)
            {
                var app = new Appartment()
                {
                    Number = this.Number,
                    Floor = this.Floor,
                    GeneralArea = this.GeneralArea,
                    LivingArea = this.LivingArea,
                    ElectricityActualCounter = this.ElectricityActualCounter,
                    WaterActualCounter = this.WaterActualCounter,
                    GasActualCounter = this.GasActualCounter,
                    ElectricityPrevCounter = this.ElectricityPrevCounter,
                    WaterPrevCounter = this.WaterPrevCounter,
                    GasPrevCounter = this.GasPrevCounter,
                    SpdtBill = this.SpdtBill,
                    SpdtPayment = this.SpdtPayment,
                    ElectricityBill = this.ElectricityBill,
                    WaterBill = this.WaterBill,
                    GasBill = this.GasBill,
                    TotalBill = this.TotalBill,
                    ElectricityPayment = this.ElectricityPayment,
                    WaterPayment = this.WaterPayment,
                    GasPayment = this.GasPayment,
                    TotalPayment = this.TotalPayment,
                };
                app.AppartmentId = context.AddNewAppartment(Number, Floor, LivingArea, GeneralArea, ElectricityBill, ElectricityPayment, WaterBill, WaterPayment,
            GasBill, GasPayment, SpdtBill, SpdtPayment, TotalBill + ElectricityBill + WaterBill + GasBill, TotalPayment + ElectricityPayment +
                WaterPayment + GasPayment, ElectricityPrevCounter, ElectricityActualCounter, WaterPrevCounter, 
            WaterActualCounter, GasPrevCounter, GasActualCounter);
                parentAppartmentViewModel.Appartments.Add(app);
            }
            else
            {
                var app = parentAppartmentViewModel.Appartments.FirstOrDefault(x => x.AppartmentId == Id);
                context.UpdateAppartment(Id, Number, Floor, LivingArea, GeneralArea, ElectricityBill, ElectricityPayment, WaterBill, WaterPayment,
            GasBill, GasPayment, SpdtBill, SpdtPayment, TotalBill + ElectricityBill + WaterBill+ GasBill, TotalPayment + ElectricityPayment +
                WaterPayment + GasPayment, ElectricityPrevCounter, ElectricityActualCounter, WaterPrevCounter,
            WaterActualCounter, GasPrevCounter, GasActualCounter);
                int i = parentAppartmentViewModel.Appartments.IndexOf(app);
                parentAppartmentViewModel.Appartments[i] = new Appartment()
                {
                    AppartmentId = Id,
                    Number = this.Number,
                    Floor = this.Floor,
                    GeneralArea = this.GeneralArea,
                    LivingArea = this.LivingArea,
                    ElectricityActualCounter = this.ElectricityActualCounter,
                    WaterActualCounter = this.WaterActualCounter,
                    GasActualCounter = this.GasActualCounter,
                    ElectricityPrevCounter = this.ElectricityPrevCounter,
                    WaterPrevCounter = this.WaterPrevCounter,
                    GasPrevCounter = this.GasPrevCounter,
                    SpdtBill = this.SpdtBill,
                    SpdtPayment = this.SpdtPayment,
                    ElectricityBill = this.ElectricityBill,
                    WaterBill = this.WaterBill,
                    GasBill = this.GasBill,
                    TotalBill = this.TotalBill,
                    ElectricityPayment = this.ElectricityPayment,
                    WaterPayment = this.WaterPayment,
                    GasPayment = this.GasPayment,
                    TotalPayment = this.TotalPayment,
                };
            }
        }
    }
}
