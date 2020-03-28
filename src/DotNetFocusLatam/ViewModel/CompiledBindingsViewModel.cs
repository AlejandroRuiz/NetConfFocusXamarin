using System;
using MvvmHelpers;

namespace DotNetFocusLatam.ViewModel
{
    public class CompiledBindingsViewModel : BaseViewModel
    {
        string _text;
        double _selectedValue;

        public CompiledBindingsViewModel()
        {
        }

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public double SelectedValue
        {
            get => _selectedValue;
            set => SetProperty(ref _selectedValue, value);
        }
    }
}
