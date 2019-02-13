using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;

namespace PrismXamarin.ViewModels.Custom
{
    public class CalculatorPageViewModel : ViewModelBase
    {
        public CalculatorPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Calculator";
        }
    }
}
