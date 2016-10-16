using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using OSBB.DesktopClient.Interfaces;

namespace OSBB.DesktopClient.Services
{
    public class UnityServiceLocator : IServiceLocator
    {
        private UnityContainer container;
        public UnityServiceLocator()
        {
            container = new UnityContainer();
        }
        public void Register<TInterface, TImplementation>(string a) where TImplementation : TInterface
        {
            container.RegisterType<TInterface, TImplementation>(a);
        }

        public TInterface Get<TInterface>(string a)
        {
            return container.Resolve<TInterface>(a);
        }
    }
}
