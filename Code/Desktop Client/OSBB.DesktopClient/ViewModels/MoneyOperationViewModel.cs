using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Input;
using OSBB.Windows;
using OSBB.Data;
using OSBB.DesktopClient.Services;
using OSBB.DesktopClient.Interfaces;

namespace OSBB.DesktopClient.ViewModels
{
    public class MoneyOperationViewModel : ViewModel
    {
                private readonly BusinessContext context;
                private PaymentModeEnum paymentMode;
                private ListAppartmentViewModel parentAppartmentViewModel;

        public MoneyOperationViewModel(ListAppartmentViewModel apvm, PaymentModeEnum mode) : this (new BusinessContext())
        {
            parentAppartmentViewModel = apvm;
            this.paymentMode = mode;
        }

        public MoneyOperationViewModel(BusinessContext context)
        {
            this.context = context;
        }
        public int Id { get; set; }
        public decimal MoneyAmmount { get; set; }
        public string OperationName
        {
            get
            {
                if (paymentMode == PaymentModeEnum.Electricity)
                {
                    return "Введите сумму оплаты за электроэнергию";
                }
                else if (paymentMode == PaymentModeEnum.Water)
                {
                    return "Введите сумму оплаты за водоснабжение";
                }
                else if (paymentMode == PaymentModeEnum.Gas)
                {
                    return "Введите сумму оплаты за газ";
                }
                else if (paymentMode == PaymentModeEnum.Spdt)
                {
                    return "Введите сумму оплаты за СПДТ";
                }
                else
                {
                    return null;
                }
            }
        }




        public ICommand MoneyOperationCommand
        {
            get
            {
                return new ActionCommand(x => MoneyOperation());
            }
        }

        private void MoneyOperation()
        {
            var app = parentAppartmentViewModel.Appartments.FirstOrDefault(x => x.AppartmentId == Id);
            if (this.paymentMode == PaymentModeEnum.Electricity)
            {
                app.ElectricityPayment += MoneyAmmount;
                app.TotalPayment += MoneyAmmount;
            }
            else if (this.paymentMode == PaymentModeEnum.Water)
            {
                app.WaterPayment += MoneyAmmount;
                app.TotalPayment += MoneyAmmount;
            }
            else if (this.paymentMode == PaymentModeEnum.Gas)
            {
                app.GasPayment += MoneyAmmount;
                app.TotalPayment += MoneyAmmount;
            }
            else if (this.paymentMode == PaymentModeEnum.Spdt)
            {
                app.SpdtPayment += MoneyAmmount;
                app.TotalPayment += MoneyAmmount;
            }
            else
            {
                return;
            }
            context.UpdateAppartment(Id, app.Number, app.Floor, app.LivingArea, app.GeneralArea, app.ElectricityBill, app.ElectricityPayment, app.WaterBill, app.WaterPayment,
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
                WaterActualCounter = app.WaterActualCounter,
                GasActualCounter = app.GasActualCounter,
                ElectricityPrevCounter = app.ElectricityPrevCounter,
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
