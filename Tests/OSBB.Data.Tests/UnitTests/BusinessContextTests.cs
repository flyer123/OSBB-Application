using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OSBB.Data.Tests.UnitTests
{
    [TestClass]
    public class BusinessContextTests : FunctionalTest
    {
        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void AddNewAppartment_ThrowsException_WhenNumberIsNegative()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        var appartment = new Appartment() {Number = -4, Floor = 2, GeneralArea = 45, LivingArea = 23, Charged = 0.0m, Payment = 0.0m };
        //        bc.AddNewAppartment(appartment);
        //    }
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void AddNewAppartment_ThrowsException_WhenFloorIsNegative()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        var appartment = new Appartment() { Number = 4, Floor = -2, GeneralArea = 45, LivingArea = 23, Charged = 0.0m, Payment = 0.0m };
        //        bc.AddNewAppartment(appartment);
        //    }
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void AddNewAppartment_ThrowsException_WhenLivingAreaIsNegative()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        var appartment = new Appartment() { Number = 4, Floor = 2, GeneralArea = 45, LivingArea = -23, Charged = 0.0m, Payment = 0.0m };
        //        bc.AddNewAppartment(appartment);
        //    }
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void AddNewAppartment_ThrowsException_WhenGeneralAreaIsNegative()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        var appartment = new Appartment() { Number = 4, Floor = 2, GeneralArea = -45, LivingArea = 23, Charged = 0.0m, Payment = 0.0m };
        //        bc.AddNewAppartment(appartment);
        //    }
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void AddNewAppartment_ThrowsException_WhenGeneralAreaIsSmallerThanLivingArea()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        var appartment = new Appartment() { Number = 4, Floor = 2, GeneralArea = 45, LivingArea = 123, Charged = 0.0m, Payment = 0.0m };
        //        bc.AddNewAppartment(appartment);
        //    }
        //}


        //[TestMethod]
        //public void UpdateAppartment_NewValuesAreApplied()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        var appartment = new Appartment() { Number = 4, Floor = 2, GeneralArea = 45, LivingArea = 23, Charged = 0.0m, Payment = 0.0m };
        //        bc.AddNewAppartment(appartment);
        //        int number = 14, floor = 3, generalArea = 53, livingArea = 33; decimal charged = 12.0m, payment = 34.0m;
        //        appartment.Number = number; appartment.Floor = floor; appartment.GeneralArea = generalArea; appartment.LivingArea = livingArea; 
        //        appartment.Charged = charged; appartment.Payment = payment;
        //        bc.UpdateAppartment(appartment);
        //        bc.DataContext.Entry(appartment).Reload();
        //        Assert.AreEqual(appartment.Number, number);
        //        Assert.AreEqual(appartment.Floor, floor);
        //        Assert.AreEqual(appartment.GeneralArea, generalArea);
        //        Assert.AreEqual(appartment.LivingArea, livingArea);
        //        Assert.AreEqual(appartment.Payment, payment);
        //        Assert.AreEqual(appartment.Charged, charged);
        //    }
        //}

        //[TestMethod]
        //public void GetListOfAppartments()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        bc.AddNewAppartment(new Appartment() { Number = 4, Floor = 2, GeneralArea = 41, LivingArea = 23, Charged = 5.0m, Payment = 1.0m });
        //        bc.AddNewAppartment(new Appartment() { Number = 5, Floor = 2, GeneralArea = 31, LivingArea = 15, Charged = 76.0m, Payment = 123.0m });
        //        bc.AddNewAppartment(new Appartment() { Number = 6, Floor = 2, GeneralArea = 56, LivingArea = 43, Charged = 6.0m, Payment = 7.0m });
        //        var appartments = bc.GetAppartmentList();
        //        Assert.IsTrue(appartments.ElementAt(0).AppartmentId == 1);
        //        Assert.IsTrue(appartments.ElementAt(1).AppartmentId == 2);
        //        Assert.IsTrue(appartments.ElementAt(2).AppartmentId == 3);
        //    }
        //}

    }
}
