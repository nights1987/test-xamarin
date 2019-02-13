using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismXamarin.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand GotoFormsPage { get; private set; }
        public DelegateCommand GotoLayoutPage { get; private set; }
        //public DelegateCommand GotoAlertPage { get; private set; }
        public DelegateCommand GotoBindingPage { get; private set; }
        public DelegateCommand GotoCalculatorPage { get; private set; }
        public DelegateCommand GotoThemePage { get; private set; }

        private DelegateCommand _navigateCommand;
        public DelegateCommand GotoAlertPage =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(GotoAlertPageAction));

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            GotoFormsPage = new DelegateCommand(GotoFormsPageAction);
            GotoLayoutPage = new DelegateCommand(GotoLayoutPageAction);
            //GotoAlertPage = new DelegateCommand(GotoAlertPageAction);
            GotoBindingPage = new DelegateCommand(GotoBindingPageAction);
            GotoCalculatorPage = new DelegateCommand(GotoCalculatorPageAction);
            GotoThemePage = new DelegateCommand(GotoThemePageAction);
        }

        private void GotoFormsPageAction()
        {
            NavigationService.NavigateAsync("FormsPage");
        }

        private void GotoLayoutPageAction()
        {
            NavigationService.NavigateAsync("LayoutPage");
        }

        private void GotoAlertPageAction()
        {
            NavigationService.NavigateAsync("AlertPage");
        }

        private void GotoBindingPageAction()
        {
            NavigationService.NavigateAsync("BindingPage");
        }

        private void GotoCalculatorPageAction()
        {
            NavigationService.NavigateAsync("CalculatorPage");
        }

        private void GotoThemePageAction()
        {
            NavigationService.NavigateAsync("ThemePage");
        }
    }
}
