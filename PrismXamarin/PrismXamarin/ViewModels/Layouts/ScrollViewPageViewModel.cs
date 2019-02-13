using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;

namespace PrismXamarin.ViewModels.Layouts
{
    public class ScrollViewPageViewModel : ViewModelBase
    {
        public ScrollViewPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Scroll View";
        }
    }
}
