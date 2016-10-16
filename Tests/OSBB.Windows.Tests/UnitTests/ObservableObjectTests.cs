using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OSBB.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace OSBB.Windows.Tests.UnitTests
{
    /// <summary>
    /// Testing whether ChangedPropertyEvent is risen,
    /// shen we change property of ObservableClass object
    /// </summary>
    [TestClass]
    public class ObservableObjectTests
    {
        [TestMethod]
        public void PropertyChangedEventHandlerIsRaised()
        {
            var obj = new StubObservableObject();
            bool raised = false;
            obj.PropertyChanged += (sender, e) =>
                                    {
                                        Assert.IsTrue(e.PropertyName == "ChangedProperty");
                                        raised = true;
                                    };
            obj.ChangedProperty = "SomeValue";
            if (!raised) Assert.Fail("Property changed was never invoked!");
        }
        class StubObservableObject : ObservableObject
        {
            private string changedProperty;
            public string ChangedProperty
            {
                get
                {
                    return changedProperty;
                }
                set
                {
                    changedProperty = value;
                    //call analog of OnMethod which invokes the delegate
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
