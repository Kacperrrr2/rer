using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ConvertersWpfApp.Converters
{
    public class ColorComponentToColorSaturationPrecentageConverter : IValueConverter
    {
        //z kodu do widoku
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is Double doubleValue)
            {
                return doubleValue / 255*100;
            }
            return 0;
        }
        //z widoku do kodu
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
