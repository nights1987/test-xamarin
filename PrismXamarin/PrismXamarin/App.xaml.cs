using Prism;
using Prism.Ioc;
using PrismXamarin.ViewModels;
using PrismXamarin.ViewModels.Custom;
using PrismXamarin.ViewModels.Forms;
using PrismXamarin.ViewModels.Layouts;
using PrismXamarin.Views;
using PrismXamarin.Views.Custom;
using PrismXamarin.Views.Forms;
using PrismXamarin.Views.Layouts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PrismXamarin
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            // Forms
            containerRegistry.RegisterForNavigation<FormsPage, FormsPageViewModel>();
            containerRegistry.RegisterForNavigation<ButtonPage, ButtonPageViewModel>();
            // Layouts
            containerRegistry.RegisterForNavigation<LayoutPage, LayoutPageViewModel>();
            containerRegistry.RegisterForNavigation<StackLayoutPage, StackLayoutPageViewModel>();
            containerRegistry.RegisterForNavigation<AbsoluteLayoutPage, AbsoluteLayoutPageViewModel>();
            containerRegistry.RegisterForNavigation<RelativeLayoutPage, RelativeLayoutPageViewModel>();
            containerRegistry.RegisterForNavigation<GridLayoutPage, GridLayoutPageViewModel>();
            containerRegistry.RegisterForNavigation<FlexLayoutPage, FlexLayoutPageViewModel>();
            containerRegistry.RegisterForNavigation<ScrollViewPage, ScrollViewPageViewModel>();
            // Other
            containerRegistry.RegisterForNavigation<AlertPage, AlertPageViewModel>();
            containerRegistry.RegisterForNavigation<BindingPage, BindingPageViewModel>();
            // Custom
            containerRegistry.RegisterForNavigation<CalculatorPage, CalculatorPageViewModel>();
            containerRegistry.RegisterForNavigation<ThemePage, ThemePageViewModel>();
        }

        protected override void OnResume()
        {
            base.OnResume();
            // TODO: Refresh network data, perform UI updates, and reacquire resources like cameras, I/O devices, etc.

        }

        protected override void OnSleep()
        {
            base.OnSleep();
            // TODO: This is the time to save app data in case the process is terminated.
            // This is the perfect timing to release exclusive resources (camera, I/O devices, etc...)
        }
    }
}
