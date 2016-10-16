using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OSBB.Windows.Tests.UnitTests
{
    [TestClass]
    public class ActionCommandTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExeptionIfActionParameterIsNull()
        {
            var command = new ActionCommand(null);
        }

        [TestMethod]
        public void ExecuteInvokesAction()
        {
            var invoked = false;
            //Action<Object> action = obj => { invoked = true; };
            Action<Object> action = delegate(Object obj)
            {
                invoked = true;
            };
            var command = new ActionCommand(action);
            command.Execute();
            Assert.IsTrue(invoked);
        }

        [TestMethod]
        public void ExecuteOverloadInvokesActionWithParameter()
        {
            var invoked = false;
            Action<Object> action = delegate(Object obj)
            {
                Assert.IsNotNull(obj);
                invoked = true;
            };
            var command = new ActionCommand(action);
            command.Execute(new Object());
            Assert.IsTrue(invoked);
        }

        [TestMethod]
        public void CanExecuteIsTrueByDefault()
        {
            var command = new ActionCommand(obj => { });
            Assert.IsTrue(command.CanExecute(null));
        }

        [TestMethod]
        public void CanExecuteOverloadExecutesTruePredicate()
        {
            var command = new ActionCommand(obj => { }, obj => (int)obj == 1);
            Assert.IsTrue(command.CanExecute(1));
        }

        [TestMethod]
        public void CanExecuteOverloadExecutesFalsePredicate()
        {
            var command = new ActionCommand(obj => { }, obj => (int)obj == 1);
            Assert.IsFalse(command.CanExecute(0));

        }
    }
}
