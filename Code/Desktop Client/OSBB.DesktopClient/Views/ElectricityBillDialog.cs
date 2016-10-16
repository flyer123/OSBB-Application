﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OSBB.DesktopClient.Interfaces;

namespace OSBB.DesktopClient.Views
{
    public class ElectricityBillDialog : IModalDialog
    {
        private ElectricityBillWindow view;
        public void BindViewModel<TViewModel>(TViewModel viewModel)
        {
            GetDialog().DataContext = viewModel;
        }

        public void ShowDialog()
        {
            GetDialog().ShowDialog();
        }

        public ElectricityBillWindow GetDialog()
        {
            if (view == null)
            {
                view = new ElectricityBillWindow();
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