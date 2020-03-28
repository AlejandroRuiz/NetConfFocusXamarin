using System;
using System.Collections.ObjectModel;
using MvvmHelpers;

namespace DotNetFocusLatam.ViewModel
{
    public class BindingPathViewModel : BaseViewModel
    {
        public BindingPathViewModel()
        {
            Title = "Binding Path";
            Entities = new ObservableCollection<Entity>
            {
                new Entity("First Item"),
                new Entity("Second Item"),
                new Entity("Thrid Item")
            };

            AwesomeEntity = new Entity("Awesome!!!!!!!");
        }

        public ObservableCollection<Entity> Entities { get; }

        public Entity AwesomeEntity { get; }
    }

    public class Entity
    {
        public Entity(string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}
