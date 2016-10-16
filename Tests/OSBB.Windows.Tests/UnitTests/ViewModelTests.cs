using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSBB.Windows;
using System.ComponentModel.DataAnnotations;

namespace OSBB.Windows.Tests.UnitTests
{
    [TestClass]
    public class ViewModelTests
    {
        [TestMethod]
        public void IsAbstractBaseClass()
        {
            Type t = typeof(ViewModel);
            Assert.IsTrue(t.IsAbstract);
        }

        [TestMethod]
        public void IsDataErrorInfo()
        {
            Assert.IsTrue(typeof(IDataErrorInfo).IsAssignableFrom(typeof(ViewModel)));
        }

        [TestMethod]
        public void isObservableObject()
        {
            Assert.IsTrue(typeof(ViewModel).BaseType == typeof(ObservableObject));
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void IDataErrorInfo_errorProeprty_NotSupported()
        {
            var viewModel = new StubViewModel();
            var value = viewModel.Error;
        }

        [TestMethod]
        public void IndexerPropertyValidatesPropertyNamedWithInvalidValue()
        {
            var viewModel = new StubViewModel();
            Assert.IsNotNull(viewModel["RequiredProperty"]);
        }

        [TestMethod]
        public void IndexerPropertyValidatesPropertyNamedWithValidValue()
        {
            var viewModel = new StubViewModel()
            {
                RequiredProperty = "Some Value"
            };

            Assert.IsNull(viewModel["RequiredProperty"]);
        }

        class StubViewModel : ViewModel
        {
            [Required]
            public string RequiredProperty { get; set; }
        }

    }
}
