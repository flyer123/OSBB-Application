using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSBB.DesktopClient.Interfaces
{
    public interface IServiceLocator
    {
        void Register<TInterface, TImplementation>(string st) where TImplementation : TInterface;
        TInterface Get<TInterface>(string a);
    }
}
