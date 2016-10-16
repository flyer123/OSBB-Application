using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OSBB.Data.Tests
{
    [TestClass]
    public class FunctionalTest
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            using (var db = new DataContext())
            {
                if (db.Database.Exists())
                    db.Database.Delete();
                db.Database.Create();
            }
            
        }

        [TestCleanup]
        public virtual void TestCleanUP()
        {
            using (var db = new DataContext())
                if (db.Database.Exists())
                    db.Database.Delete();
            
        }
    }
}
