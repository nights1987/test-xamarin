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
    public class ThemePageViewModel : ViewModelBase
    {
        private bool isDarkTheme = true;
        public DelegateCommand<string> GotoSwitchTheme { get; private set; }

        public ThemePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Theme";
            GotoSwitchTheme = new DelegateCommand<string>(GotoSwitchThemeAction);
        }

        private void GotoSwitchThemeAction(string theme)
        {
            //TODO
            if (isDarkTheme)
            {
            }
            else
            {
            }

            isDarkTheme = !isDarkTheme;
        }
    }
}
