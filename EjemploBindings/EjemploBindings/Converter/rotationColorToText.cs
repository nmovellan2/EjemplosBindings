using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace EjemploBindings.Converter
{
    public class RotationColorToText : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double rotation = (double)value;
            Color ColorResult;
            if (rotation >= 270)
            {
                ColorResult = Color.Green;
            }
            else if (rotation >= 180)
            {
                ColorResult =  Color.Red;
            }
            else if (rotation >= 90)
            {
                ColorResult = Color.Blue;
            }
            else
            {
                ColorResult = Color.Orange;
            }

            return ColorResult.R.ToString() + ','+ ColorResult.G.ToString() + ',' + ColorResult.B.ToString()  ;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
