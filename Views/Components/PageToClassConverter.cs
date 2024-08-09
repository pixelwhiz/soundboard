using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace soundboard.Views.Components;

public class PageToClassConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string strValue)
        {
            return strValue == "Home" ? "active" : "";
        }
        return "";
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return "";
    }
}