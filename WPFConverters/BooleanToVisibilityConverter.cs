using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFConverters
{
    public class BooleanToVisibilityConverter : BaseValueConverter<BooleanToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (parameter == null)
            {
                return (bool)value ? Visibility.Visible : Visibility.Hidden;
            }
            else if ((string)parameter == "Invert")
            {
                return (bool)value ? Visibility.Collapsed : Visibility.Visible;
                //return (bool)value ? Visibility.Visible : Visibility.Hidden;
            }
            else if ((string)parameter == "Collapse")
            {
                return (bool)value ? Visibility.Visible : Visibility.Collapsed;
                //return (bool)value ? Visibility.Visible : Visibility.Hidden;
            }
            else
            {
                return (bool)value ? Visibility.Visible : Visibility.Collapsed;
                //return (bool)value ? Visibility.Visible : Visibility.Hidden;
            }

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
