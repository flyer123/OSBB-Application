using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSBB.DesktopClient.ViewModels;
using OSBB.Windows;

namespace OSBB.DesktopClient.Tests.UnitTests
{
    [TestClass]
    public class AppartmentViewModelTests
    {
        //[TestMethod]
        //public void IsViewModel()
        //{
        //    Assert.IsTrue(typeof(AppartmentViewModel).BaseType == typeof(ViewModel));
        //}

        //[TestMethod]
        //public void AddAppartmentButtonIsdisabledWhenNumberIsNotValid()
        //{
        //    var viewModel = new AppartmentViewModel() { Number = -1, Floor = 1, GeneralArea = 10, LivingArea = 8, Charged = 5.6m, Payment = 0.0m};
        //    Assert.IsFalse(viewModel.AddAppartmentCommand.CanExecute(null));
        //}

        //[TestMethod]
        //public void AddAppartmentButtonIsdisabledWhenFloorIsNotValid()
        //{
        //    var viewModel = new AppartmentViewModel() { Number = 1, Floor = -1, GeneralArea = 10, LivingArea = 8, Charged = 5.6m, Payment = 0.0m };
        //    Assert.IsFalse(viewModel.AddAppartmentCommand.CanExecute(null));
        //}

        //[TestMethod]
        //public void AddAppartmentButtonIsdisabledWhenLivingAreaIsGreaterThanGeneralArea()
        //{
        //    var viewModel = new AppartmentViewModel() { Number = 1, Floor = 1, GeneralArea = 10, LivingArea = 18, Charged = 5.6m, Payment = 0.0m };
        //    Assert.IsFalse(viewModel.AddAppartmentCommand.CanExecute(null));
        //}

        //[TestMethod]
        //public void AddAppartmentToAppartmentsCollectionWhenExecutedSuccesfully()
        //{
        //    var viewModel = new AppartmentViewModel() { Number = 1, Floor = 1, GeneralArea = 10, LivingArea = 8, Charged = 5.6m, Payment = 0.0m };
        //    viewModel.AddAppartmentCommand.Execute();
        //    Assert.IsTrue(viewModel.Appartments.Count == 1);
        //}
    }
}
