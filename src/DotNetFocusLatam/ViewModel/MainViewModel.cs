using System;
using System.Threading.Tasks;
using AsyncAwaitBestPractices.MVVM;
using MvvmHelpers;
using Xamarin.Forms;

namespace DotNetFocusLatam.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public static readonly string BasicBindingPage = nameof(BasicBindingPage);

        public static readonly string BindingFallbacksPage = nameof(BindingFallbacksPage);

        public static readonly string BindingModePage = nameof(BindingModePage);

        public static readonly string BindingPathPage = nameof(BindingPathPage);

        public static readonly string RelativeBindingsPage = nameof(RelativeBindingsPage);

        public static readonly string StringFormatPage = nameof(StringFormatPage);

        public static readonly string ValueConverterPage = nameof(ValueConverterPage);

        public static readonly string CompiledBindingsPage = nameof(CompiledBindingsPage);

        public MainViewModel()
        {
            Title = "Data Bindings";
            NavigateCommand = new AsyncCommand<string>(NavigateAsync);
        }

        public IAsyncCommand<string> NavigateCommand { get; }

        private Task NavigateAsync(string target)
        {
            var type = Type.GetType($"DotNetFocusLatam.View.{target}, DotNetFocusLatam");
            var targetPage = (Page)Activator.CreateInstance(type);
            return Application.Current.MainPage.Navigation.PushAsync(targetPage);
        }
    }
}
