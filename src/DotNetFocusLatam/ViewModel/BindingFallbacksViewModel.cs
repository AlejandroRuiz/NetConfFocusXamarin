using System;
using MvvmHelpers;

namespace DotNetFocusLatam.ViewModel
{
    public class BindingFallbacksViewModel : BaseViewModel
    {
        public BindingFallbacksViewModel()
        {
            Title = "Binding Fallbacks";
            MyEntity1 = new Entity1();
            MyEntity2 = new Entity2 { Title = null };
        }

        public Entity1 MyEntity1 { get; }

        public Entity2 MyEntity2 { get; }
    }

    public class Entity1
    {
    }

    public class Entity2
    {
        public string Title { get; set; }
    }
}
