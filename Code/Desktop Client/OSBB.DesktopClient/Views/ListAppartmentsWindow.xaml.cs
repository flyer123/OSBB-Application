﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OSBB.DesktopClient.Views
{
    /// <summary>
    /// Interaction logic for ListAppartmentsWindow.xaml
    /// </summary>
    public partial class ListAppartmentsWindow : Window
    {
        public ListAppartmentsWindow()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

    }
}
