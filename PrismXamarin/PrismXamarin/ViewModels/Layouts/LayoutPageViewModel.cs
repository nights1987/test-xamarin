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
    public class LayoutPageViewModel : ViewModelBase
    {
        public DelegateCommand GotoStackLayoutPage { get; private set; }
        public DelegateCommand GotoAbsoluteLayoutPage { get; private set; }
        public DelegateCommand GotoRelativeLayoutPage { get; private set; }
        public DelegateCommand GotoGridLayoutPage { get; private set; }
        public DelegateCommand GotoFlexLayoutPage { get; private set; }
        public DelegateCommand GotoScrollViewPage { get; private set; }

        public LayoutPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Layouts";
            GotoStackLayoutPage = new DelegateCommand(GotoStackLayoutPageAction);
            GotoAbsoluteLayoutPage = new DelegateCommand(GotoAbsoluteLayoutPageAction);
            GotoRelativeLayoutPage = new DelegateCommand(GotoRelativeLayoutPageAction);
            GotoGridLayoutPage = new DelegateCommand(GotoGridLayoutPageAction);
            GotoFlexLayoutPage = new DelegateCommand(GotoFlexLayoutPageAction);
            GotoScrollViewPage = new DelegateCommand(GotoScrollViewPageAction);
        }

        private void GotoStackLayoutPageAction()
        {
            NavigationService.NavigateAsync("StackLayoutPage");
        }

        private void GotoAbsoluteLayoutPageAction()
        {
            NavigationService.NavigateAsync("AbsoluteLayoutPage");
        }

        private void GotoRelativeLayoutPageAction()
        {
            NavigationService.NavigateAsync("RelativeLayoutPage");
        }

        private void GotoGridLayoutPageAction()
        {
            NavigationService.NavigateAsync("GridLayoutPage");
        }

        private void GotoFlexLayoutPageAction()
        {
            NavigationService.NavigateAsync("FlexLayoutPage");
        }

        private void GotoScrollViewPageAction()
        {
            NavigationService.NavigateAsync("ScrollViewPage");
        }
    }
}
