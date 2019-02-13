using Xamarin.Forms;

namespace PrismXamarin.Views.Layouts
{
    public partial class GridLayoutPage
    {
        public GridLayoutPage()
        {
            InitializeComponent();

            ////var grid = new Grid();
            //var grid = new Grid { ColumnSpacing = 5 };

            //grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //var topLeft = new Label { Text = "Top Left" };
            //var topRight = new Label { Text = "Top Right" };
            //var bottomLeft = new Label { Text = "Bottom Left" };
            //var bottomRight = new Label { Text = "Bottom Right" };

            //// left, top
            //grid.Children.Add(topLeft, 0, 0);
            //grid.Children.Add(topRight, 1, 0);
            //grid.Children.Add(bottomLeft, 0, 1);
            //grid.Children.Add(bottomRight, 1, 1);

            ////// left, right, top, bottom
            ////grid.Children.Add(topLeft, 0, 1, 0, 1);
            ////grid.Children.Add(topRight, 1, 2, 0, 1);
            ////grid.Children.Add(bottomLeft, 0, 1, 1, 2);
            ////grid.Children.Add(bottomRight, 1, 2, 1, 2);

            ////left & top arguments will always refer to cells within the Grid.
            ////right & bottom arguments may appear to refer to cells that are outside the Grid.
            ////the right argument must always be greater than the left argument
            ////the bottom argument must always be greater than the top argument.

            //Content = grid;
        }
    }
}
