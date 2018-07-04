using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace EjemploBindings.Converter
{
    public class RotationToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double rotation = (double)value;
            if(rotation>=270)
            {
                return Color.Green;
            }else if(rotation>=180)
            {
                return Color.Red;
            }else if(rotation>=90)
            {
                return Color.Blue;
            }else
            {
                return Color.Orange;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
