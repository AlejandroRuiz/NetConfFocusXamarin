using System;
using System.Globalization;
using MvvmHelpers;
using Xamarin.Forms;

namespace DotNetFocusLatam.ViewModel
{
    public class ValueConverterViewModel : BaseViewModel
    {
        bool _isActivated;

        public ValueConverterViewModel()
        {
            Title = "Value Converters";
        }

        public bool IsActivated
        {
            get => _isActivated;
            set => SetProperty(ref _isActivated, value);
        }
    }

    public class BoolValueConverter : IValueConverter
    {
        public object TrueValue { get; set; }

        public object FalseValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolean)
            {
                return boolean ? TrueValue : FalseValue;
            }
            throw new Exception("Invalid parameter detected a bool value was expected");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
