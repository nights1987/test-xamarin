using Xamarin.Forms;

namespace PrismXamarin.Views.Layouts
{
    public partial class StackLayoutPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();

            //var layout = new StackLayout();
            //var button = new Button { Text = "StackLayout", VerticalOptions = LayoutOptions.Start, HorizontalOptions = LayoutOptions.FillAndExpand };
            //var yellowBox = new BoxView { Color = Color.Yellow, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            //var greenBox = new BoxView { Color = Color.Green, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            //var redBox = new BoxView { Color = Color.Red, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };

            //FIXME: HeightRequest = 75, when render => not display like set in XAML
            //var blueBox = new BoxView { Color = Color.Blue, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, HeightRequest = 75 };

            //layout.Children.Add(button);
            //layout.Children.Add(yellowBox);
            //layout.Children.Add(greenBox);
            //layout.Children.Add(redBox);
            //layout.Children.Add(blueBox);
            //layout.Spacing = 10;

            //Content = layout;
        }
    }
}
