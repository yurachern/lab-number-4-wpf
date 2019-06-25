using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfLaba
{
    class DateFormatting : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTime)value).ToString(CultureInfo.CurrentCulture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DateTime.Parse(value.ToString());
        }
    }
}
