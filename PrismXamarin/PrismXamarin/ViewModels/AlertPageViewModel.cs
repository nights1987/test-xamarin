using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using System.Diagnostics;

namespace PrismXamarin.ViewModels
{
    public class AlertPageViewModel : ViewModelBase
    {
        //IPageDialogService _dialogService;
        public DelegateCommand Alert { get; private set; }
        public DelegateCommand Confirm { get; private set; }
        public DelegateCommand Sheet { get; private set; }

        //public AlertPageViewModel(INavigationService navigationService, IPageDialogService dialogService) : base(navigationService)
        public AlertPageViewModel(INavigationService navigationService, IPageDialogService dialogService) : base(navigationService, dialogService)
        {
            //_dialogService = dialogService;
            Title = "Alert";
            Alert = new DelegateCommand(AlertAction);
            Confirm = new DelegateCommand(ConfirmAction);
            Sheet = new DelegateCommand(SheetActionAsync);
        }

        private void AlertAction()
        {
            //_dialogService.DisplayAlertAsync("Alert", "You have been alerted", "OK");
            PageDialogService.DisplayAlertAsync("Alert", "You have been alerted!", "OK");
        }

        private async void ConfirmAction()
        {
            var action = await PageDialogService.DisplayAlertAsync("Confirm", "Would you like to play a game?", "Yes", "No");
            await PageDialogService.DisplayAlertAsync("Alert", $"You choose '{action}'", "OK");
        }

        private async void SheetActionAsync()
        {
            //var action = await PageDialogService.DisplayActionSheetAsync("Send to", "Cancel", null, "Facebook", "Twitter", "Email");
            var action = await PageDialogService.DisplayActionSheetAsync("Send to:", "Cancel", "Destroy", "Facebook", "Twitter", "Email");
            await PageDialogService.DisplayAlertAsync("Alert", $"You choose '{action}'", "OK");
        }
    }
}
