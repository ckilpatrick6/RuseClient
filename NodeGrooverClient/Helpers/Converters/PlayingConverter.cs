using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace NodeGrooverClient.Helpers.Converters
{
    public class PlayingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool playing = (bool)value;
            if (playing)
                return "\uE103";
            else
                return "\uE102";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string icon = (string)value;
            if (icon == "\uE102")
                return false;
            else
                return true;
        }
    }

}
