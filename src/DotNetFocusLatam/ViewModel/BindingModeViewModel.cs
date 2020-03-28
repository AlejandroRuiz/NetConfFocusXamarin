using System;
using System.Threading.Tasks;
using AsyncAwaitBestPractices.MVVM;
using MvvmHelpers;

namespace DotNetFocusLatam.ViewModel
{
    public class BindingModeViewModel : BaseViewModel
    {
        string _text;
        double _progress;
        int _sliderValue;

        public BindingModeViewModel()
        {
            Title = "Binding Mode";
            Text = "Hello";
            PerformActionCommand = new AsyncCommand(PerformActionAsync);
        }

        public IAsyncCommand PerformActionCommand { get; }

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public double Progress
        {
            get => _progress;
            set => SetProperty(ref _progress, value);
        }

        public int SliderValue
        {
            get => _sliderValue;
            set => SetProperty(ref _sliderValue, value);
        }

        private async Task PerformActionAsync()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;
            while (Progress < 1)
            {
                await Task.Delay(500);
                Progress += 0.1;
            }
            IsBusy = false;
        }
    }
}
