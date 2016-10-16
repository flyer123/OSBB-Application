using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OSBB.DesktopClient.Interfaces;

namespace OSBB.DesktopClient.Views
{
    public class PaymentDialog : IModalDialog
    {
        private PaymentView view;
        public void BindViewModel<TViewModel>(TViewModel viewModel)
        {
            GetDialog().DataContext = viewModel;
        }

        public void ShowDialog()
        {
            GetDialog().ShowDialog();
        }

        public PaymentView GetDialog()
        {
            if (view == null)
            {
                view = new PaymentView();
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
