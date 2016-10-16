using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace OSBB.Windows
{
    /// <summary>
    /// Observable object implementation, base class
    /// to notify ui elements
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {
        //declare PropertyChangedeventHandler delegate
       public event PropertyChangedEventHandler PropertyChanged;
       protected void NotifyPropertyChanged([CallerMemberName] string propertyChanged="")
       {
           //Instantiate delegate
           PropertyChangedEventHandler handler = PropertyChanged;
           if (handler != null)
           {
               //if delegate not null --> call subscribed methods
               handler(this, new PropertyChangedEventArgs(propertyChanged));
           }
       }
    }
}
