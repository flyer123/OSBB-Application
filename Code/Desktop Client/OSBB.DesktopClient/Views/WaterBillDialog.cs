using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OSBB.DesktopClient.Interfaces;

namespace OSBB.DesktopClient.Views
{
    public class WaterBillDialog : IModalDialog
    {
        private WaterBillWindow view;
        public void BindViewModel<TViewModel>(TViewModel viewModel)
        {
            GetDialog().DataContext = viewModel;
        }

        public void ShowDialog()
        {
            GetDialog().ShowDialog();
        }

        public WaterBillWindow GetDialog()
        {
            if (view == null)
            {
                view = new WaterBillWindow();
                view.Closed += new EventHandler(view_Closed);
            }
            return view;
        }

        public void Close()
        {
            GetDialog().Close();
        }
        void view_Closed(object sender, EventArgs e)
        {
            view = null;
        }
    }
}
