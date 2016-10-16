using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using OSBB.DesktopClient.Views;

namespace OSBB.DesktopClient
{
    using ViewModels;
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [DllImport("user32", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindow(string cls, string win);
        [DllImport("user32")]
        static extern IntPtr SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32")]
        static extern bool IsIconic(IntPtr hWnd);
        [DllImport("user32")]
        static extern bool OpenIcon(IntPtr hWnd);
        protected override void OnStartup(StartupEventArgs e)
        {
            bool isNew;
            var mutex = new Mutex(true, "ListAppartmentsWindow", out isNew);
            if (!isNew)
            {
                ActivateOtherWindow();
                Shutdown();
            }
            BootStrapper.Initialize();
            var window = new ListAppartmentsWindow()
            {
                DataContext = new ListAppartmentViewModel()
            };
            ListAppartmentViewModel apvm = (ListAppartmentViewModel)window.DataContext;
            apvm.GetAppartmentsCommand.Execute(null);
            window.ShowDialog();
            base.OnStartup(e);
        }

        private static void ActivateOtherWindow()
        {
            var other = FindWindow(null, "OnlySingle");
            if (other != IntPtr.Zero)
            {
                SetForegroundWindow(other);
                if (IsIconic(other))
                    OpenIcon(other);
            }
        }
    }
}
