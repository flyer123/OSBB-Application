using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSBB.Windows;
using OSBB.DesktopClient.ViewModels;

namespace OSBB.DesktopClient.Tests.UnitTests
{
    [TestClass]
    public class OccupantViewModelTests
    {
        //[TestMethod]
        //public void IsViewModel()
        //{
        //    Assert.IsTrue(typeof(OccupantViewModel).BaseType == typeof(ViewModel));
        //}

        //[TestMethod]
        //public void AddOccupantButtonIsdisabledWhenFirstNameIsNotValid()
        //{
        //    var viewModel = new OccupantViewModel() {FirstName = "", LastName = "Ivanov", Gender = GenderEnumeration.Gender.male, MiddleName = "", Owner = false };
        //    Assert.IsFalse(viewModel.AddOccupantCommand.CanExecute(null));
        //}

        //[TestMethod]
        //public void AddOccupantButtonIsdisabledWhenLastNameIsNotValid()
        //{
        //    var viewModel = new OccupantViewModel() { FirstName = "Ivan", LastName = "", Gender = GenderEnumeration.Gender.male, MiddleName = "", Owner = false };
        //    Assert.IsFalse(viewModel.AddOccupantCommand.CanExecute(null));
        //}

        //[TestMethod]
        //public void AddOccupantToOccupantsCollectionWhenExecutedSuccesfully()
        //{
        //    var viewModel_o = new OccupantViewModel() { FirstName = "Ivan", LastName = "Ivanov", AppartmentId=1, Gender = GenderEnumeration.Gender.male, MiddleName = "", Owner = false };
        //    viewModel_o.AddOccupantCommand.Execute();
        //    Assert.IsTrue(viewModel_o.Occupants.Count == 1);
        //}

    }
}
