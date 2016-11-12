using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace OSBB.Windows
{
    public class CustomCommand
    {
        private object parameter;
        public CustomCommand(object parameter)
        {
            this.parameter = parameter;
        }
    }
}
