using System;
using System.Globalization;
using Xamarin.Forms;

namespace Contacts
{
    public class BooleanToStarConverter : IValueConverter
    {
        private const string PositiveString = "★";
        private const string NegativeString = "☆";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool && (bool)value)
            {
                return PositiveString;
            }

            return NegativeString;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as string) == PositiveString;
        }
    }
}
