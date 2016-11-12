using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace OSBB.DesktopClient
{
    //to convert criterions fo filter result methods into one command parameter
    public class FilterValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            FindFilterParameters findFilterParameters = new FindFilterParameters();
            if (values[0] == DependencyProperty.UnsetValue)
            {
                findFilterParameters.Min = 0;
            }
            else if (values[0].Equals(""))
            {
                findFilterParameters.Min = 0;
            }
            else
            {
                findFilterParameters.Min = Decimal.Parse(values[0].ToString());
            }
            if (values[1] == DependencyProperty.UnsetValue)
            {
                findFilterParameters.Max = 0;
            }
            else if (values[1].Equals(""))
            {
                findFilterParameters.Max = 0;
            }
            else
            {
                findFilterParameters.Max = Decimal.Parse(values[0].ToString());
            }
            if (values[2] == DependencyProperty.UnsetValue)
            {
                findFilterParameters.Criterion = "";
            }
            else
            {
                findFilterParameters.Criterion = findFilterParameters.Criterion = values[2].ToString();
            }
            if (values[3] == DependencyProperty.UnsetValue)
            {
                findFilterParameters.IsAscending = false;
            }
            else
            {
                findFilterParameters.IsAscending = findFilterParameters.IsAscending = (bool)values[3];
            }
            return findFilterParameters;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class FindFilterParameters
    {
        public string Criterion { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public bool IsAscending { get; set; }
    }
}
