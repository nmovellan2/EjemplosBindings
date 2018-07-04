using EjemploBindings.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace EjemploBindings.Converter
{
    public class SemaphoreToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SemaphoreState state = (SemaphoreState)value;
            switch (state)
            {
                case SemaphoreState.Green:
                    return Color.Green;
                    break;
                case SemaphoreState.Yellow:
                    return Color.Yellow;
                    break;
                case SemaphoreState.Red:
                    return Color.Red;
                    break;
                default:
                    return Color.Black;
                    break;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
