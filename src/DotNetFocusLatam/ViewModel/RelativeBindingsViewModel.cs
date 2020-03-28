using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MvvmHelpers;
using Xamarin.Forms;

namespace DotNetFocusLatam.ViewModel
{
    public class RelativeBindingsViewModel : BaseViewModel
    {
        public RelativeBindingsViewModel()
        {
            Title = "Relative Bindings";
            RemoveCommand = new Command<AwesomeEntity>(RemoveItem);
            MyEntities = new ObservableCollection<AwesomeEntity>
            {
                new AwesomeEntity("Item 1"),
                new AwesomeEntity("Item 2"),
                new AwesomeEntity("Item 3"),
                new AwesomeEntity("Item 4")
            };
        }

        public ICommand RemoveCommand { get; }

        public ObservableCollection<AwesomeEntity> MyEntities { get; }

        private void RemoveItem(AwesomeEntity entity)
        {
            MyEntities.Remove(entity);
        }
    }

    public class AwesomeEntity
    {
        public AwesomeEntity(string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}
