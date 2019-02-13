using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using Xamarin.Forms;

namespace PrismXamarin.ViewModels.Forms
{
    public class ButtonPageViewModel : ViewModelBase
    {
        public Label SampleLabel { get; private set; } = new Label();
        public DelegateCommand OnButtonClicked { get; private set; }

        public ButtonPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Button";
            SampleLabel.Text = "Hello World";
            OnButtonClicked = new DelegateCommand(OnButtonClickedAction);
        }

        private void OnButtonClickedAction()
        {
            SampleLabel.RelRotateTo(360, 1000);
        }
    }
}
