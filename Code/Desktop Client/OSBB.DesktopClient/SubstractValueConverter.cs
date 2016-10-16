using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace OSBB.DesktopClient
{
    // used to receives two decimal values
    // and to return difference between them
    // when substractin second value from first
    public class SubstractValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            decimal result = (decimal)values[0] - (decimal)values[1];
            return result.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
