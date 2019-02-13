using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;

namespace PrismXamarin.ViewModels.Forms
{
    public class FormsPageViewModel : ViewModelBase
    {
        public DelegateCommand GotoButtonPage { get; private set; }

        public FormsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Forms";
            GotoButtonPage = new DelegateCommand(GotoButtonPageAction);
        }

        private void GotoButtonPageAction()
        {
            NavigationService.NavigateAsync("ButtonPage");
        }
    }
}
