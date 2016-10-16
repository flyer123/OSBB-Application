using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSBB.DesktopClient.Services;
using OSBB.DesktopClient.Interfaces;
using OSBB.DesktopClient.Views;

namespace OSBB.DesktopClient
{
    public class BootStrapper
    {
        public static void Initialize()
        {
            ServiceProvider.RegisterServiceLocator(new UnityServiceLocator());
            ServiceProvider.Instance.Register<IModalDialog, AppartmentDialog>("appartmentImplementation");
            ServiceProvider.Instance.Register<IModalDialog, OccupantDialog>("occupantImplementation");
            ServiceProvider.Instance.Register<IModalDialog, ElectricityBillDialog>("electricityBillDialogImplementation");
            ServiceProvider.Instance.Register<IModalDialog, WaterBillDialog>("waterBillDialogImplementation");
            ServiceProvider.Instance.Register<IModalDialog, GasBillDialog>("gasBillDialogImplementation");
            ServiceProvider.Instance.Register<IModalDialog, SpdtBillDialog>("spdtBillDialogImplementation");
            ServiceProvider.Instance.Register<IModalDialog, PaymentDialog>("paymentOperationDialogImplementation");
        }
    }
}
