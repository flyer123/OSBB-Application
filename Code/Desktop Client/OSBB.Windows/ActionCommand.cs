using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace OSBB.Windows
{
    /// <summary>
    /// type implements ICommand interface
    /// </summary>
    public class ActionCommand : ICommand
    {
        private readonly Action<Object> action;
        private readonly Predicate<Object> predicate;
        public ActionCommand(Action<Object> action)
            : this(action, null)
        {
        }
        public ActionCommand(Action<Object> action, Predicate<Object> predicate)
        {
            if (action == null)
            {
                throw new ArgumentNullException("action", "You must specify an Action<T>.");
            }
            this.action = action;
            this.predicate = predicate;
        }

        public bool CanExecute(object parameter)
        {
            if (predicate == null)
            {
                return true;
            }
            return predicate(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            action(parameter);
        }
        public void Execute()
        {
            Execute(null);
        }
    }
}
