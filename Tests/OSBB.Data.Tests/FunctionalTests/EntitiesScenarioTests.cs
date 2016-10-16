using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenderEnumeration;

namespace OSBB.Data.Tests.FunctionalTests
{
    [TestClass]
    public class EntitiesScenarioTests : FunctionalTest
    {
        //[TestMethod]
        //public void AddNewAppartmentIsPersisted()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        Appartment appartment = new Appartment() { Number = 3, Floor = 1, GeneralArea = 40, LivingArea = 28, Charged = 0.0m, Payment = 0.0m };
        //        bc.AddNewAppartment(appartment);
        //        bool exists = bc.DataContext.Appartments.Any(x => x.AppartmentId == appartment.AppartmentId);
        //        Assert.IsTrue(exists);

        //    }
        //}


        //[TestMethod]
        //public void AddNewPersonToExistAppartment()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        Appartment appartment = new Appartment() { Number = 3, Floor = 1, GeneralArea = 40, LivingArea = 28, Charged = 0.0m, Payment = 0.0m };
        //        bc.AddNewAppartment(appartment);
        //        Occupant occupant = new Occupant() { FirstName = "Ivan", LastName = "Ivanov", MiddleName = "", BirthDate = new DateTime(1987, 1, 1), Gender = Gender.male, Owner = true };
        //        bc.AddNewOccupant(1, occupant);
        //        bool exists = bc.DataContext.Occupants.Any(x => x.OccupantId == occupant.OccupantId);
        //        Assert.IsTrue(exists);
        //    }
        //}


        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void AddNewPersonToNonExistAppartment()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        Appartment appartment = new Appartment() { Number = 3, Floor = 1, GeneralArea = 40, LivingArea = 28, Charged = 0.0m, Payment = 0.0m };
        //        bc.AddNewAppartment(appartment);
        //        Occupant occupant = new Occupant() { FirstName = "Ivan", LastName = "Ivanov", MiddleName = "", BirthDate = new DateTime(1987, 1, 1), Gender = Gender.male, Owner = true };
        //        bc.AddNewOccupant(5, occupant);
        //        bool exists = bc.DataContext.Occupants.Any(x => x.OccupantId == occupant.OccupantId);
        //        Assert.IsTrue(exists);
        //    }
        //}

        //[TestMethod]
        //public void TestIfDeleteAppartmentSucceeds()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        Appartment appartment = new Appartment() { Number = 3, Floor = 1, GeneralArea = 40, LivingArea = 28, Charged = 0.0m, Payment = 0.0m };
        //        bc.AddNewAppartment(appartment);
        //        Occupant occupant = new Occupant() { FirstName = "Ivan", LastName = "Ivanov", MiddleName = "", BirthDate = new DateTime(1987, 1, 1), Gender = Gender.male, Owner = true };
        //        bc.AddNewOccupant(appartment.AppartmentId, occupant);
        //        bc.DeleteAppartment(1);
        //        bool exists = bc.DataContext.Appartments.Any(x => x.AppartmentId == appartment.AppartmentId);
        //        Assert.IsFalse(exists);
        //    }
        //}

        //[TestMethod]
        //public void TestIfDeletePersonSucceeds()
        //{
        //    using (var bc = new BusinessContext())
        //    {
        //        Appartment appartment = new Appartment() { Number = 3, Floor = 1, GeneralArea = 40, LivingArea = 28, Charged = 0.0m, Payment = 0.0m };
        //        bc.AddNewAppartment(appartment);
        //        Occupant occupant = new Occupant() { FirstName = "Ivan", LastName = "Ivanov", MiddleName = "", BirthDate = new DateTime(1987, 1, 1), Gender = Gender.male, Owner = true };
        //        bc.AddNewOccupant(appartment.AppartmentId, occupant);
        //        bc.DeleteOccupant(1);
        //        bool exists = bc.DataContext.Occupants.Any(x => x.OccupantId == occupant.OccupantId);
        //        Assert.IsFalse(exists);
        //    }
        //}

    }
}
