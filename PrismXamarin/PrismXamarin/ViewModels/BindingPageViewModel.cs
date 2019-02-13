using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using PrismXamarin.Models;
using System.Diagnostics;

namespace PrismXamarin.ViewModels
{
    public class BindingPageViewModel : ViewModelBase
    {
        public UserModel UserInfo { get; set; }
        public DelegateCommand OnSubmit { get; private set; }
        public DelegateCommand OnCancel { get; private set; }

        public BindingPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Binding";
            UserInfo = new UserModel();
            OnSubmit = new DelegateCommand(OnSubmitAction);
            OnCancel = new DelegateCommand(OnCancelAction);
        }

        private void OnSubmitAction()
        {
            Debug.WriteLine($"===========> {UserInfo.FirstName}");
        }

        private void OnCancelAction()
        {
            NavigationService.GoBackAsync();
        }
    }
}
